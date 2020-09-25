using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;
using System.Data;

namespace TESTWF2020.DataAccessLayer
{
    public class ConsultaDao
    {
        internal IList<Consulta> GetAll()
        {
            var listaConsulta = new List<Consulta>();

            string consultaSql = "SELECT " +
                "c.idConsulta, " +
                "c.fechaCreada, " +
                "c.usuarioCreado, " +
                "t.nombre as nombreTipoTransaccion, " +
                "i.idInmueble, " +
                "cl.dni as dni, " +
                "cl.nombre as nombre, " +
                "cl.apellido as apellido, " +
                "m.nombre as nombreMedioConocimiento, " +
                "v.nombre as nombreViaDeConsulta, " +
                "e.nombre as nombreEstadoConsulta, " +
                "c.fechaCierre, " +
                "c.usuarioActualizacion " +
                "FROM Consulta c " +
                "INNER JOIN Usuario u on c.usuarioCreado = u.nombre " +
                "INNER JOIN TipoTransaccion t on c.idTipoTransaccion = t.idTipoTransaccion " +
                "INNER JOIN Inmueble i on c.idInmueble = i.idInmueble " +
                "INNER JOIN Cliente cl on c.dniCliente = cl.dni " +
                "INNER JOIN MedioConocimiento m on c.idMedioConocimiento = m.idMedioConocimiento " +
                "INNER JOIN ViaDeConsulta v on c.idViaDeConsulta = v.idViaDeConsulta " +
                "INNER JOIN EstadoConsulta e on c.idEstadoConsulta = e.idEstadoConsulta " +
                "WHERE c.borrado = 0 ";

            DataManager dm = new DataManager();

            var resultado = dm.ConsultaSQL2(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    listaConsulta.Add(MapToEntity(row));
                }
            }

            return listaConsulta;
        }

        public IList<Consulta> GetByFilters(Dictionary<string, object> diccParametros)
        {
            var listaConsultas = new List<Consulta>();

            string consultaSql = "SELECT " +
                "c.idConsulta, " +
                "c.fechaCreada, " +
                "c.usuarioCreado, " +
                "t.nombre as nombreTipoTransaccion, " +
                "i.idInmueble, " +
                "i.calle, " +
                "i.calleNro, " +
                "cl.dni as dni, " +
                "cl.nombre as nombre, " +
                "cl.apellido as apellido, " +
                "m.nombre as nombreMedioConocimiento, " +
                "v.nombre as nombreViaDeConsulta, " +
                "e.nombre as nombreEstadoConsulta, " +
                "c.fechaCierre, " +
                "c.usuarioActualizacion " +
                "FROM Consulta c " +
                "INNER JOIN Usuario u on c.usuarioCreado = u.nombre " +
                "INNER JOIN TipoTransaccion t on c.idTipoTransaccion = t.idTipoTransaccion " +
                "INNER JOIN Inmueble i on c.idInmueble = i.idInmueble " +
                "INNER JOIN Cliente cl on c.dniCliente = cl.dni " +
                "INNER JOIN MedioConocimiento m on c.idMedioConocimiento = m.idMedioConocimiento " +
                "INNER JOIN ViaDeConsulta v on c.idViaDeConsulta = v.idViaDeConsulta " +
                "INNER JOIN EstadoConsulta e on c.idEstadoConsulta = e.idEstadoConsulta " +
                "WHERE c.borrado = 0 ";

            consultaSql = AgregarParametros(diccParametros, consultaSql);

            DataManager dm = new DataManager();

            var resultado = dm.ConsultaSQLConParametros2(consultaSql, diccParametros);
            foreach (DataRow row in resultado.Rows)
                listaConsultas.Add(MapToEntity(row));

            return listaConsultas;
        }

        private string AgregarParametros(Dictionary<string, object> diccParametros, string consultaSql)
        {
            if (diccParametros.ContainsKey("idConsulta"))
                consultaSql += " AND (c.idConsulta = @idConsulta) ";

            if (diccParametros.ContainsKey("usuarioCreador"))
                consultaSql += " AND (c.usuarioCreado LIKE '%' + @usuarioCreador + '%') ";

            if (diccParametros.ContainsKey("tipoTransaccion"))
                consultaSql += " AND (t.idTipoTransaccion = @tipoTransaccion) ";

            if (diccParametros.ContainsKey("direccionInmueble"))
                consultaSql += " AND (i.calle LIKE '%' + @direccionInmueble + '%') ";

            if (diccParametros.ContainsKey("dniCliente"))
                consultaSql += " AND (cl.dni LIKE '%' + @dniCliente + '%') ";

            if (diccParametros.ContainsKey("nombreCliente"))
                consultaSql += " AND (cl.nombre LIKE '%' + @nombreCliente + '%') ";

            if (diccParametros.ContainsKey("apellidoCliente"))
                consultaSql += " AND (cl.apellido LIKE '%' + @apellidoCliente + '%') ";

            if (diccParametros.ContainsKey("medioConocimiento"))
                consultaSql += " AND (m.idMedioConocimiento = @medioConocimiento) ";

            if (diccParametros.ContainsKey("viaDeConsulta"))
                consultaSql += " AND (v.idViaDeConsulta = @viaDeConsulta) ";

            if (diccParametros.ContainsKey("estadoConsulta"))
                consultaSql += " AND (e.idEstadoConsulta = @estadoConsulta) ";

            if (diccParametros.ContainsKey("usuarioActualizacion"))
                consultaSql += " AND (c.usuarioActualizacion LIKE '%' + @usuarioActualizacion + '%') ";

            return consultaSql;
        }

        public void Delete(int id)
        {
            var parametros = new Dictionary<string, object>();

            string consultaSql = "UPDATE Consulta SET borrado = 1 WHERE idConsulta = @id " ;

            parametros.Add("id", id);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        public void Create(Consulta consulta)
        {
            string ConsultaSql = "INSERT INTO Consulta " +
                "(fechaCreada, " +
                "usuarioCreado, " +
                "idTipoTransaccion, " +
                "idInmueble, " +
                "dniCliente, " +
                "idMedioConocimiento, " +
                "idViaDeConsulta, " +
                "idEstadoConsulta, " +
                "fechaCierre, " +
                "usuarioActualizacion) " +
                "VALUES " +
                "(@fechaCreada, " +
                "@usuarioCreado, " +
                "@idTipoTransaccion, " +
                "@idInmueble, " +
                "@dniCliente, " +
                "@idMedioConocimiento, " +
                "@idViaDeConsulta, " +
                "@idEstadoConsulta, " +
                "@fechaCierre, " +
                "@usuarioActualizacion)";

            var parametros = CrearDiccionario(consulta);

            DataManager dm = new DataManager();
            dm.EjecutarSQLConParametros2(ConsultaSql, parametros);
        }

        private Dictionary<string, object> CrearDiccionario(Consulta consulta)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("idConsulta", consulta.Id);
            parametros.Add("fechaCreada", consulta.FechaCreada);
            parametros.Add("usuarioCreado", consulta.UsuarioCreado);
            parametros.Add("idTipoTransaccion", consulta.TipoTransaccion.Id);
            parametros.Add("idInmueble", consulta.Inmueble.Id);
            //parametros.Add("dniCliente", consulta.Cliente.Dni);
            parametros.Add("idMedioConocimiento", consulta.MedioConocimiento.Id);
            parametros.Add("idViaDeConsulta", consulta.ViaDeConsulta.Id);
            parametros.Add("idEstadoConsulta", consulta.EstadoConsulta.Id);
            parametros.Add("fechaCierre", consulta.FechaCierre);
            parametros.Add("usuarioActualizacion", consulta.UsuarioActualizacion);

            return parametros;
        }

        public void Update(Consulta consulta)
        {
            string consultaSql = "UPDATE Consulta SET " +
                "fechaCreada = @fechaCreada, " +
                "usuarioCreado = @usuarioCreado, " +
                "idTipoTransaccion = @idTipoTransaccion, " +
                "idInmueble = @idInmueble, " +
                "dniCliente = @dniCliente, " +
                "idMedioConocimiento = @idMedioConocimiento, " +
                "idViaDeConsulta = @idViaDeConsulta, " +
                "idEstadoConsulta = @idEstadoConsulta, " +
                "fechaCierre = @fechaCierre, " +
                "usuarioActualizacion = @usuarioActualizacion " +
                "WHERE idConsulta = @idConsulta ";

            var parametros = CrearDiccionario(consulta);

            DataManager dm = new DataManager();

            dm.EjecutarSQLConParametros2(consultaSql, parametros);

        }

        private Consulta MapToEntity(DataRow row)
        {
            Consulta consulta = new Consulta
            {
                Id = (int)row["idConsulta"],
                FechaCreada = (DateTime)row["fechaCreada"],
                UsuarioCreado = row["usuarioCreado"].ToString(),
                TipoTransaccion = new TipoTransaccion
                {
                    //Id = (int)row["idTipoTransaccion"],
                    Nombre = row["nombreTipoTransaccion"].ToString(),
                    //Descripcion = row["descripcion"].ToString()
                },
                Inmueble = new Inmueble
                {
                    Id = (int)row["idInmueble"],
                    Calle = row["calle"].ToString(),
                    CalleNumero = (int)row["calleNro"],
                    //MetrosCuadrados = (double)row["m2"],
                    //Baños = (int)row["cantBaños"],
                    //Habitaciones = (int)row["cantHabitaciones"],
                    //Descripcion = row["descripcion"].ToString(),
                    //MontoAlquiler = (int)row["montoalquiler"],
                    //MontoVenta = (int)row["montoventa"],
                    //TipoInmueble = new TipoInmueble()
                    //{
                    //    Id = (int)row["idTipoInmueble"],
                    //    //Nombre = row["nombre"].ToString(),
                    //    //Descripcion = row["descripcionTipoInmueble"].ToString()
                    //}
                },

                //DniCliente = (int)row["dni"],
                //NombreCliente = row["nombre"].ToString(),
                //ApellidoCliente = row["apellido"].ToString(),

                MedioConocimiento = new MedioDeConocimiento
                {
                    //Id = (int)row["idMedioConocimiento"],
                    Nombre = row["nombreMedioConocimiento"].ToString(),
                    //Descripcion = row["descripcion"].ToString()
                },
                ViaDeConsulta = new ViaDeConsulta
                {
                    //Id = (int)row["idViaDeConsulta"],
                    Nombre = row["nombreViaDeConsulta"].ToString(),
                    //Descripcion = row["descripcion"].ToString()
                },
                EstadoConsulta = new EstadoConsulta
                {
                    //Id = (int)row["idEstadoConsulta"],
                    Nombre = row["nombreEstadoConsulta"].ToString(),
                    //Descripcion = row["descripcion"].ToString()
                },
                FechaCierre = row["fechaCierre"] != DBNull.Value ? (DateTime)row["fechaCierre"] : (DateTime?)null,
                UsuarioActualizacion = row["usuarioActualizacion"].ToString()
            };

            return consulta;
        }
    }
}
