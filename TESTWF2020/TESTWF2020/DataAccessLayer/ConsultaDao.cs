using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;
using System.Data;
using System.Windows.Forms;
using TESTWF2020.BusinessLayer;

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
                "c.usuarioUltimaModificacion, " +
                "t.idTipoTransaccion, " +
                "t.nombre as nombreTipoTransaccion, " +
                "i.idInmueble, " +
                "i.calle, " +
                "i.calleNro, " +
                "cl.dni as dni, " +
                "cl.nombre as nombre, " +
                "cl.apellido as apellido, " +
                "m.idMedioConocimiento, " +
                "m.nombre as nombreMedioConocimiento, " +
                "v.idViaDeConsulta, " +
                "v.nombre as nombreViaDeConsulta, " +
                "e.idEstadoConsulta, " +
                "e.nombre as nombreEstadoConsulta, " +
                "c.fechaCierre " +
                "FROM Consulta c " +
                "INNER JOIN Usuario u on c.usuarioUltimaModificacion = u.nombre " +
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
                "c.usuarioUltimaModificacion, " +
                "t.idTipoTransaccion, " +
                "t.nombre as nombreTipoTransaccion, " +
                "i.idInmueble, " +
                "i.calle, " +
                "i.calleNro, " +
                "cl.dni as dni, " +
                "cl.nombre as nombre, " +
                "cl.apellido as apellido, " +
                "m.idMedioConocimiento, " +
                "m.nombre as nombreMedioConocimiento, " +
                "v.idViaDeConsulta, " +
                "v.nombre as nombreViaDeConsulta, " +
                "e.idEstadoConsulta, " +
                "e.nombre as nombreEstadoConsulta, " +
                "c.fechaCierre " +
                "FROM Consulta c " +
                "INNER JOIN Usuario u on c.usuarioUltimaModificacion = u.nombre " +
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

        public Consulta GetById(int id)
        {
            string consultaSql = "SELECT " +
                "c.idConsulta, " +
                "c.fechaCreada, " +
                "c.usuarioUltimaModificacion, " +
                "t.idTipoTransaccion, " +
                "t.nombre as nombreTipoTransaccion, " +
                "i.idInmueble, " +
                "i.calle, " +
                "i.calleNro, " +
                "cl.dni as dni, " +
                "cl.nombre as nombre, " +
                "cl.apellido as apellido, " +
                "m.idMedioConocimiento, " +
                "m.nombre as nombreMedioConocimiento, " +
                "v.idViaDeConsulta, " +
                "v.nombre as nombreViaDeConsulta, " +
                "e.idEstadoConsulta, " +
                "e.nombre as nombreEstadoConsulta, " +
                "c.fechaCierre " +
                "FROM Consulta c " +
                "INNER JOIN Usuario u on c.usuarioUltimaModificacion = u.nombre " +
                "INNER JOIN TipoTransaccion t on c.idTipoTransaccion = t.idTipoTransaccion " +
                "INNER JOIN Inmueble i on c.idInmueble = i.idInmueble " +
                "INNER JOIN Cliente cl on c.dniCliente = cl.dni " +
                "INNER JOIN MedioConocimiento m on c.idMedioConocimiento = m.idMedioConocimiento " +
                "INNER JOIN ViaDeConsulta v on c.idViaDeConsulta = v.idViaDeConsulta " +
                "INNER JOIN EstadoConsulta e on c.idEstadoConsulta = e.idEstadoConsulta " +
                "WHERE c.borrado = 0 " +
                $"AND c.idConsulta = {id}";

            DataManager dm = new DataManager();

            var resultado = dm.ConsultaSQL2(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                return MapToEntity(resultado.Rows[0]);
            }
            return null;
        }

        private string AgregarParametros(Dictionary<string, object> diccParametros, string consultaSql)
        {
            if (diccParametros.ContainsKey("idConsulta"))
                consultaSql += " AND (c.idConsulta = @idConsulta) ";

            if (diccParametros.ContainsKey("usuarioUltimaModificacion"))
                consultaSql += " AND (c.usuarioUltimaModificacion LIKE '%' + @usuarioUltimaModificacion + '%') ";

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
                "usuarioUltimaModificacion, " +
                "idTipoTransaccion, " +
                "idInmueble, " +
                //"dniCliente, " +
                "idMedioConocimiento, " +
                "idViaDeConsulta, " +
                "idEstadoConsulta " +
                (consulta.FechaCierre != null ? ", fechaCierre" : "") +
                ") " +
                "VALUES " +
                "(GETUTCDATE(), " +
                "@usuarioUltimaModificacion, " +
                "@idTipoTransaccion, " +
                "@idInmueble, " +
                //"@dniCliente, " +
                "@idMedioConocimiento, " +
                "@idViaDeConsulta, " +
                "@idEstadoConsulta " +
                (consulta.FechaCierre != null ? ", @fechaCierre" : "") +
                ")";

            var parametros = CrearDiccionario(consulta);

            DataManager dm = new DataManager();
            dm.EjecutarSQLConParametros2(ConsultaSql, parametros);
        }

        private Dictionary<string, object> CrearDiccionario(Consulta consulta)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("idConsulta", consulta.Id);
            parametros.Add("usuarioUltimaModificacion", consulta.UsuarioUltimaModificacion.Nombre);
            parametros.Add("idTipoTransaccion", consulta.TipoTransaccion.Id);
            parametros.Add("idInmueble", consulta.Inmueble.Id);
            //parametros.Add("dniCliente", consulta.Cliente.Dni);
            parametros.Add("idMedioConocimiento", consulta.MedioConocimiento.Id);
            parametros.Add("idViaDeConsulta", consulta.ViaDeConsulta.Id);
            parametros.Add("idEstadoConsulta", consulta.EstadoConsulta.Id);
            if (consulta.FechaCierre != null)
                parametros.Add("fechaCierre", consulta.FechaCierre);

            return parametros;
        }

        public void Update(Consulta consulta)
        {
            string consultaSql = "UPDATE Consulta SET " +
                "usuarioUltimaModificacion = @usuarioUltimaModificacion, " +
                "idTipoTransaccion = @idTipoTransaccion, " +
                "idInmueble = @idInmueble, " +
                //"dniCliente = @dniCliente, " +
                "idMedioConocimiento = @idMedioConocimiento, " +
                "idViaDeConsulta = @idViaDeConsulta, " +
                "idEstadoConsulta = @idEstadoConsulta " +
                (consulta.FechaCierre != null ? ", fechaCierre = @fechaCierre " : "") +
                " WHERE idConsulta = @idConsulta ";

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
                UsuarioUltimaModificacion = new Usuario
                {
                    Nombre = row["usuarioUltimaModificacion"].ToString(),
                },                
                TipoTransaccion = new TipoTransaccion
                {
                    Id = (int)row["idTipoTransaccion"],
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
                    Id = (int)row["idMedioConocimiento"],
                    Nombre = row["nombreMedioConocimiento"].ToString(),
                    //Descripcion = row["descripcion"].ToString()
                },
                ViaDeConsulta = new ViaDeConsulta
                {
                    Id = (int)row["idViaDeConsulta"],
                    Nombre = row["nombreViaDeConsulta"].ToString(),
                    //Descripcion = row["descripcion"].ToString()
                },
                EstadoConsulta = new EstadoConsulta
                {
                    Id = (int)row["idEstadoConsulta"],
                    Nombre = row["nombreEstadoConsulta"].ToString(),
                    //Descripcion = row["descripcion"].ToString()
                },
                FechaCierre = row["fechaCierre"] != DBNull.Value ? (DateTime)row["fechaCierre"] : (DateTime?)null,
            };

            return consulta;
        }
    }
}
