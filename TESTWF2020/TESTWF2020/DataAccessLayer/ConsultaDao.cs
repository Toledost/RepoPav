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
                //"INNER JOIN Usuario u on c.usuarioCreado = u.nombre " +
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
                "cl.dni as dni, " +
                "cl.nombre as nombre, " +
                "cl.apellido as apellido, " +
                "m.nombre as nombreMedioConocimiento, " +
                "v.nombre as nombreViaDeConsulta, " +
                "e.nombre as nombreEstadoConsulta, " +
                "c.fechaCierre, " +
                "c.usuarioActualizacion " +
                "FROM Consulta c " +
                //"INNER JOIN Usuario u on c.usuarioCreado = u.nombre " +
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

            if (diccParametros.ContainsKey("idInmueble"))
                consultaSql += " AND (i.idInmueble = @idInmueble) ";

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
                    //Calle = row["calle"].ToString(),
                    //CalleNumero = (int)row["calleNro"],
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

                DniCliente = (int)row["dni"],
                NombreCliente = row["nombre"].ToString(),
                ApellidoCliente = row["apellido"].ToString(),

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
                FechaCierre = row["fechaCierre"] != DBNull.Value ? (DateTime)row["fechaCierre"] : default,
                UsuarioActualizacion = row["usuarioActualizacion"].ToString()
            };

            return consulta;
        }
    }
}
