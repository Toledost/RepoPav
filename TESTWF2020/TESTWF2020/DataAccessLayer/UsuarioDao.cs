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
            string consultaSQL = string.Format ("SELECT u.usuario, u.contraseña, u.fechaAlta, p.idPerfil, p.nombre" +
                "p.descripcion FROM usuario u JOIN perfil p ON u.idPerfil = p.idPerfil WHERE u.nombre ='{0}' ",nombreUsuario);

            DataTable resultado = DBHelper.GetDBHelper().ConsultaSql(consultaSQL);

            if (resultado.Rows.Count > 0)
            {
                return MapToEntity(resultado.Rows[0]);
            }
            return null;
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
                

