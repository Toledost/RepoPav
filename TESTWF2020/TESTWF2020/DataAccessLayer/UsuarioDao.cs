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

        internal IList<Usuario> GetAll()
        {
            IList<Usuario> usuarios = new List<Usuario>();
            DataManager dm = new DataManager();
            string consultaSQL = "SELECT * " +
                                "FROM Usuario " +
                                "WHERE borrado = 0";
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
                    Descripcion = row["descripcion"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    IdPerfil = (int)row["idPerfil"]
                }
            };
            return usuario; 
        }
        #endregion
    }
}
                

