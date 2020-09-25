using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    public class UsuarioDao
    {
        #region Metodos Publicos
        public Usuario GetUsuario(string nombreUsuario, bool buscarBorrado = false)
        {
            string consultaSQL = string.Format ("SELECT u.nombre, " +
                "u.contraseña, " +
                "u.fechaAlta, " +
                "p.idPerfil, " +
                "p.nombre AS nombrePerfil, " +
                "p.descripcion " +
                "FROM usuario u " +
                "JOIN perfil p ON u.idPerfil = p.idPerfil " +
                "WHERE " +
                $" u.borrado = {(buscarBorrado ? 1 : 0)} AND " +
                " u.nombre = '{0}'", nombreUsuario);

            //DataTable resultado = DBHelper.GetDBHelper().ConsultaSql(consultaSQL);
            DataManager dm = new DataManager();
            var resultado = dm.ConsultaSQL2(consultaSQL);

            if (resultado.Rows.Count > 0)
            {
                return MapToEntity(resultado.Rows[0]);
            }
            return null;
        }

        internal void Insert(Usuario user)
        {
            string consultaSQL = "INSERT INTO Usuario " +
                                "(nombre, " +
                                "contraseña, " +
                                "fechaAlta, " +
                                "idPerfil) " +
                                "VALUES " +
                                "(@nombre, " +
                                "@contraseña, " +
                                "GetUTCDATE(), " +
                                "@idPerfil)";
            var parametros = CrearDiccionarioDeParametros(user);
            DataManager dm = new DataManager();
            var insertado = dm.EjecutarSQLConParametros2(consultaSQL,parametros);
        }

        internal void Recuperar(string nombreUsuarioSeleccionado)
        {
            var parametros = new Dictionary<string, object>();

            string consultaSql = "UPDATE Usuario SET borrado = 0 " +
                " WHERE nombre = @nombre";

            parametros.Add("nombre", nombreUsuarioSeleccionado);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        internal void Delete(string nombreUsuarioSeleccionado)
        {
            var parametros = new Dictionary<string, object>();

            string consultaSql = "UPDATE Usuario SET borrado = 1" +
                " WHERE nombre = @nombre";

            parametros.Add("nombre", nombreUsuarioSeleccionado);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        internal void Update(Usuario user, string nombreOriginal)
        {
            string consultaSql = " UPDATE Usuario " +
                "SET " +
                " [nombre] = @nombre " +
                ",[contraseña] = @contraseña " +
                ",[idPerfil] = @idPerfil " +
                " WHERE nombre = @nombreOriginal ";
               

            //no va esta parte
            //if (cambioEstado)
            //{
            //    consultaSql += " UPDATE Usuario SET nombre = @nombre " + 
            //        "WHERE nombre = @nombre ";
            //}
            var parametros = new Dictionary<string, object>();

            parametros.Add("nombre", user.Nombre);
            parametros.Add("contraseña", user.Contraseña);
            parametros.Add("idPerfil", user.Perfil.IdPerfil);
            parametros.Add("nombreOriginal", nombreOriginal);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);

        }

        internal IList<Usuario> GetByFilters(Dictionary<string,object> dicc)
        {
            IList<Usuario> usuarios = new List<Usuario>();
            string consultaSQL = "SELECT u.nombre," +
                " p.idPerfil," +
                " p.nombre AS nombrePerfil," +
                " u.contraseña," +
                " u.fechaAlta " +
                " FROM Usuario u " +
                " JOIN Perfil p on u.idPerfil = p.idPerfil " +
                " WHERE " +
                " u.borrado = 0 ";

            DataManager dm = new DataManager();
            consultaSQL = AgregarParametros(dicc, consultaSQL);
            var resultado = dm.ConsultaSQLConParametros2(consultaSQL,dicc);
            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    usuarios.Add(MapToEntity(row));
                }
            }
            return usuarios;
            
        }

        private string AgregarParametros(Dictionary<string,object> dicc, string consultaSQL)
        {
            if (dicc.ContainsKey("nombre"))
            {
                consultaSQL += " AND u.nombre LIKE '%' + @nombre + '%' ";
            }
            if (dicc.ContainsKey("idPerfil"))
            {
                consultaSQL += " AND p.idPerfil = @idPerfil ";
            }
            return consultaSQL;
        }

        internal IList<Usuario> GetAll()
        {
            IList<Usuario> usuarios = new List<Usuario>();
            string consultaSQL = "SELECT u.nombre," +
                " p.idPerfil," +
                " p.nombre AS nombrePerfil ," +
                " u.contraseña," +
                " u.fechaAlta " +
                " FROM Usuario u " +
                " JOIN Perfil p on u.idPerfil = p.idPerfil " +
                " WHERE u.borrado = 0";
            DataManager dm = new DataManager();
            var resultadoSQL = dm.ConsultaSQL2(consultaSQL);
            if (resultadoSQL.Rows.Count > 0)
            {
                foreach (DataRow row in resultadoSQL.Rows)
                {
                    usuarios.Add(MapToEntity(row));
                }
            }
            return usuarios;
        }

        private Dictionary<string,object> CrearDiccionarioDeParametros(Usuario user)
        {
            Dictionary<string, object> diccionario = new Dictionary<string, object>();
            diccionario.Add("nombre", user.Nombre);
            diccionario.Add("contraseña", user.Contraseña);
            diccionario.Add("idPerfil", user.Perfil.IdPerfil);
            return diccionario;
        }
        #endregion

        #region Mapeo
        private Usuario MapToEntity(DataRow row)
        {
            Usuario usuario = new Usuario
            {
                Nombre = row["nombre"].ToString(),
                Contraseña = row["contraseña"].ToString(),
                FechaAlta = (DateTime)row["fechaAlta"],
                Perfil = new Perfil
                {
                    Nombre = row["nombrePerfil"].ToString(),
                    IdPerfil = (int)row["idPerfil"]
                }
            };
            return usuario; 
        }
       
        #endregion
    }
}
                

