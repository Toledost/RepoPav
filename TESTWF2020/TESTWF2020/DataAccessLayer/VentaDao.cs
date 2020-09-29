using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    class VentaDao
    {
        internal void Grabar(Venta venta)
        {
            string consultaSQLVenta = "INSERT INTO Venta " +
                                //"[vendedor], " +
                                //"[legajoVendedor], " +
                                "([idInmueble], " +
                                "[fechaVenta], " +
                                "[fechaEntrega], " +
                                "[dniCliente], " +
                                "[montoTotal], " +
                                "[montoCuota], " +
                                "[esFinanciada]) " +
                                //"[financiacion]) " +
                                "VALUES " +
                                //"@vendedor, " +
                                //"@legajoVendedor, " +
                                "(@idInmueble, " +
                                "@fechaVenta, " +
                                "@fechaEntrega, " +
                                "@dniCliente, " +
                                "@montoTotal, " +
                                "@montoCuota, " +
                                "@esFinanciada) ";
                                //"@financiacion) ";
            var parametrosVenta = CrearDiccionario(venta);

            DataManager dm = new DataManager();

            dm.Open();
            dm.BeginTransaction();

            try
            {
                dm.EjecutarSQLConParametros(consultaSQLVenta, parametrosVenta);

                string consutlaSQLConsulta = "UPDATE Consulta " +
                                             "SET " +
                                             "idEstadoConsulta = 4 " +
                                             "WHERE dniCliente = @dniCliente AND idInmueble = @idInmueble AND idEstadoConsulta != 1";

                var parametrosConsulta = new Dictionary<string, object>();
                parametrosConsulta.Add("dniCliente", venta.Cliente.Dni);
                parametrosConsulta.Add("idInmueble", venta.Inmueble.Id);

                dm.EjecutarSQLConParametros(consutlaSQLConsulta, parametrosConsulta);

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
                parametrosHistorialNuevo.Add("idEstadoInmueble", 3);                //TODO: cambiar nro 3

                dm.EjecutarSQLConParametros(consultaSqlHistorialNuevo, parametrosHistorialNuevo);
            }
            catch
            {
                dm.Rollback();
            }
            finally
            {
                dm.Close();
            }

        }

        private Dictionary<string, object> CrearDiccionario(Venta venta)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("idVenta", venta.IdVenta );
            parametros.Add("fechaVenta", venta.FechaVenta);
            parametros.Add("fechaEntrega", venta.FechaEntrega);
            //parametros.Add("financiacion", venta.Financiacion);
            parametros.Add("idInmueble", venta.Inmueble.Id);
            //parametros.Add("legajoVendedor", venta.Vendedor.Legajo);
            parametros.Add("dniCliente", venta.Cliente.Dni);
            parametros.Add("esFinanciada", venta.EsFinanciada);
            parametros.Add("montoTotal", venta.MontoTotal); 
            parametros.Add("montoCuota", venta.MontoCuota);

            return parametros;
        }
    }
}
