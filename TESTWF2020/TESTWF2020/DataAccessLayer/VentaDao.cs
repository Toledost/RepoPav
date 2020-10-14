using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    class VentaDao
    {
        internal bool Grabar(Venta venta)
        {
            string consultaSQLVenta = "INSERT INTO Venta " +
                                "([legajoVendedor], " +
                                "[idInmueble], " +
                                "[fechaVenta], " +
                                "[fechaEntrega], " +
                                "[dniCliente], " +
                                "[montoTotal], " +
                                "[montoCuota], " +
                                "[esFinanciada]" +
                                (venta.EsFinanciada ? ", [financiacion]) " : ") ") +
                                "VALUES " +
                                "((SELECT legajo " +
                                "FROM Empleado e " +
                                "INNER JOIN Usuario u ON e.usuario = u.nombre " +
                                "WHERE u.nombre = @usuarioVendedor), " +
                                "@idInmueble, " +
                                "@fechaVenta, " +
                                "@fechaEntrega, " +
                                "@dniCliente, " +
                                "@montoTotal, " +
                                "@montoCuota, " +
                                "@esFinanciada" +
                                (venta.EsFinanciada ? ", @financiacion) " : ")");
            var parametrosVenta = CrearDiccionario(venta);

            DataManager dm = new DataManager();

            

            try
            {
                dm.Open();
                dm.BeginTransaction();
                dm.EjecutarSQLConParametros(consultaSQLVenta, parametrosVenta);
                var newIdVenta = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");

                string consultaSQLConsulta = "UPDATE Consulta " +
                                             "SET " +
                                             "idEstadoConsulta = 4, " +
                                             "fechaCierre = GETDATE(), " +
                                             "usuarioUltimaModificacion = @usuarioVendedor " +
                                             "WHERE dniCliente = @dniCliente AND idInmueble = @idInmueble";

                var parametrosConsulta = new Dictionary<string, object>();
                parametrosConsulta.Add("dniCliente", venta.Cliente.Dni);
                parametrosConsulta.Add("idInmueble", venta.Inmueble.Id);
                parametrosConsulta.Add("usuarioVendedor", venta.UsuarioVendedor.Nombre);

                dm.EjecutarSQLConParametros(consultaSQLConsulta, parametrosConsulta);

                var consultaSqlHistorialFin = "UPDATE HistorialEstado " +
                                               "SET fechaFin = GetDATE() " +
                                               "WHERE idInmueble = @idInmueble " +
                                               "AND fechaFin IS NULL ";

                Dictionary<string, object> parametrosHistorialFin = new Dictionary<string, object>();
                parametrosHistorialFin.Add("idInmueble", venta.Inmueble.Id);

                dm.EjecutarSQLConParametros(consultaSqlHistorialFin, parametrosHistorialFin);


                // Creamos un nuevo historial con el estado pasado por parametro para ese inmueble
                string consultaSqlHistorialNuevo = "INSERT INTO HistorialEstado " +
                    "(idInmueble, " +
                    "idEstadoInmueble, " +
                    "fechaInicio) " +
                    "VALUES (@idInmueble, " +
                    "@idEstadoInmueble, " +
                    "GETDATE()) ";

                var parametrosHistorialNuevo = new Dictionary<string, object>();

                parametrosHistorialNuevo.Add("idInmueble", venta.Inmueble.Id);
                parametrosHistorialNuevo.Add("idEstadoInmueble", venta.EsFinanciada ? 4 : 3);

                dm.EjecutarSQLConParametros(consultaSqlHistorialNuevo, parametrosHistorialNuevo);

                if (venta.EsFinanciada)
                {
                    string consultaSqlCuotas = "DECLARE @numeroCuota int = 1 " +
                        "WHILE @cuotas > 0 " +
                        "BEGIN " +
                        "INSERT INTO Cuota " +
                        "(nroCuota, " +
                        "idVenta, " +
                        "fechaVencimiento) " +
                        "VALUES " +
                        "(@numeroCuota, " +
                        "@idVenta, " +
                        "DATEADD(month, @numeroCuota, GETDATE())) " +
                        "SET @cuotas = @cuotas - 1 " +
                        "SET @numeroCuota = @numeroCuota + 1 " +
                        "END";

                    var parametrosCuota = new Dictionary<string, object>();
                    parametrosCuota.Add("cuotas", venta.Financiacion.CantidadCuotas);
                    parametrosCuota.Add("idVenta", newIdVenta);

                    dm.EjecutarSQLConParametros(consultaSqlCuotas, parametrosCuota);
                }

                dm.Commit();
                return true;
            }
            catch
            {
                dm.Rollback();
                return false;
            }
            finally
            {
                dm.Close();
            }

        }

        internal IList<Venta> GetByDni(string dni)
        {
            IList<Venta> listaVentas = new List<Venta>();

            var dm = new DataManager();

            string consultaSQL = "SELECT " +
                "idVenta, " +
                "legajoVendedor, " +
                "v.idInmueble, " +
                "fechaVenta, " +
                "fechaEntrega, " +
                "dniCliente, " +
                "montoTotal, " +
                "montoCuota, " +
                "esFinanciada, " +
                "financiacion, " +
                "c.nombre AS NombreCliente, " +
                "c.apellido AS ApellidoCliente, " +
                "e.legajo AS LegajoVendedor, " +
                "e.nombre AS NombreVendedor, " +
                "e.apellido AS ApellidoVendedor, " +
                "u.nombre AS NombreUsuario, " +
                "i.calle, " +
                "i.calleNro " +
                "FROM Venta v " +
                "JOIN cliente c on v.dniCliente = c.dni " +
                "JOIN empleado e on e.legajo = v.legajoVendedor " +
                "JOIN usuario u on e.usuario = u.nombre " +
                "JOIN inmueble i on i.idInmueble = v.idInmueble " +
                "WHERE v.borrado = 0 " +
                $"AND v.dniCliente = {dni}";

            var busqueda = dm.ConsultaSQL2(consultaSQL);

            if (busqueda.Rows.Count > 0)
            {
                foreach (DataRow row in busqueda.Rows)
                {
                    listaVentas.Add(MapToEntity(row));
                }
            }
            return listaVentas;
        }

        internal IList<Venta> GetAll()
        {
            IList<Venta> listaVentas = new List<Venta>();

            var dm = new DataManager();

            string consultaSQL = "SELECT " +
                "idVenta, " +
                "legajoVendedor, " +
                "v.idInmueble, " +
                "fechaVenta, " +
                "fechaEntrega, " +
                "dniCliente, " +
                "montoTotal, " +
                "montoCuota, " +
                "esFinanciada, " +
                "financiacion, " +
                "c.nombre AS NombreCliente, " +
                "c.apellido AS ApellidoCliente, " +
                "e.legajo AS LegajoVendedor, " +
                "e.nombre AS NombreVendedor, " +
                "e.apellido AS ApellidoVendedor, " +
                "u.nombre AS NombreUsuario, " +
                "i.calle, " +
                "i.calleNro " +
                "FROM Venta v " +
                "JOIN cliente c on v.dniCliente = c.dni " +
                "JOIN empleado e on e.legajo = v.legajoVendedor " +
                "JOIN usuario u on e.usuario = u.nombre " +
                "JOIN inmueble i on i.idInmueble = v.idInmueble " +
                "WHERE v.borrado = 0";

            var busqueda = dm.ConsultaSQL2(consultaSQL);

            if (busqueda.Rows.Count > 0)
            {
                foreach (DataRow row in busqueda.Rows)
                {
                    listaVentas.Add(MapToEntity(row));
                }
            }
            return listaVentas;
        }

        private Dictionary<string, object> CrearDiccionario(Venta venta)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("idVenta", venta.IdVenta );
            parametros.Add("fechaVenta", venta.FechaVenta);
            parametros.Add("fechaEntrega", venta.FechaEntrega);
            parametros.Add("idInmueble", venta.Inmueble.Id);
            parametros.Add("usuarioVendedor", venta.UsuarioVendedor.Nombre);
            parametros.Add("dniCliente", venta.Cliente.Dni);
            parametros.Add("esFinanciada", venta.EsFinanciada);
            parametros.Add("montoTotal", venta.MontoTotal); 
            parametros.Add("montoCuota", venta.MontoCuota);

            if(venta.EsFinanciada)
                parametros.Add("financiacion", venta.Financiacion.IdFinanciacion);

            return parametros;
        }

        private Venta MapToEntity(DataRow row)
        {
            Venta venta = new Venta
            {
                IdVenta = (int)row["idVenta"],
                EsFinanciada = (bool)row["esFinanciada"],
                FechaVenta = (DateTime)row["fechaVenta"],
                FechaEntrega = (DateTime)row["fechaEntrega"],
                Cliente = new Cliente
                {
                    Dni = (int)row["dniCliente"],
                    Nombre = row["nombreCliente"].ToString(),
                    Apellido = row["apellidoCliente"].ToString()
                },
                MontoCuota = float.Parse(row["montoCuota"].ToString()),
                UsuarioVendedor = new Usuario
                {
                    Nombre = row["nombreUsuario"].ToString()
                },
                Inmueble = new Inmueble
                {
                    Id = (int)row["idInmueble"],
                    Calle = row["calle"].ToString(),
                    CalleNumero = (int)row["calleNro"]
                },
                EmpleadoVendedor = new Empleado
                {
                    Nombre = row["nombreVendedor"].ToString(),
                    Apellido = row["apellidoVendedor"].ToString(),
                    Legajo = (int)row["legajoVendedor"]
                }
            };

            return venta;
        }
    }
}
