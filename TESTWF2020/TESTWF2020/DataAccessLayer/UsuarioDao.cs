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
        public Usuario GetUsuario(string nombreUsuario)
        {
            string consultaSQL = string.Format ("SELECT u.usuario, u.contraseña, u.fechaAlta, p.idPerfil, p.nombre, p.descripcion FROM usuario u JOIN perfil p ON u.idPerfil = p.idPerfil WHERE u.usuario = '{0}'", nombreUsuario);

            DataTable resultado = DBHelper.GetDBHelper().ConsultaSql(consultaSQL);

            if (resultado.Rows.Count > 0)
            {
                return MapToEntity(resultado.Rows[0]);
            }
            return null;
        }

        internal void Insert(Usuario user)
        {
            string consultaSQL = "INSERT INTO Usuario " +
                                "(usuario, " +
                                "contraseña, " +
                                "fechaAlta, " +
                                "idPerfil) " +
                                "VALUES " +
                                "(@usuario, " +
                                "@contraseña, " +
                                "GetUTCDATE(), " +
                                "@idPerfil)";
            var parametros = CrearDiccionarioDeParametros(user);
            DataManager dm = new DataManager();
            var insertado = dm.EjecutarSQLConParametros2(consultaSQL,parametros);

        }

        internal IList<Usuario> GetByFilters(Dictionary<string,object> dicc)
        {
            IList<Usuario> usuarios = new List<Usuario>();
            string consultaSQL = "SELECT u.usuario," +
                " p.idPerfil," +
                " p.nombre," +
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
            if (dicc.ContainsKey("usuario"))
            {
                consultaSQL += " AND u.usuario LIKE '%' + @usuario + '%' ";
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
            string consultaSQL = "SELECT u.usuario," +
                " p.idPerfil," +
                " p.nombre," +
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
            diccionario.Add("usuario", user.Nombre);
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
                Nombre = row["usuario"].ToString(),
                Contraseña = row["contraseña"].ToString(),
                FechaAlta = (DateTime)row["fechaAlta"],
                Perfil = new Perfil
                {
                    Nombre = row["nombre"].ToString(),
                    IdPerfil = (int)row["idPerfil"]
                }
            };
            return usuario; 
        }
        //private Perfil MapToEntity2(DataRow row)
        //{
        //    Perfil perfil = new Perfil
        //    {
        //        IdPerfil = (int)row["idPerfil"],
        //        Nombre = row["nombre"].ToString(),
        //        Descripcion = row["descripcion"].ToString()
        //    };
        //    return perfil;
        //}
        #endregion
    }
}
                

