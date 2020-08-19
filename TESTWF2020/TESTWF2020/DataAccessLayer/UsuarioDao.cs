using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    class UsuarioDao
    {
        #region Metodos Publicos
        public Usuario GetUsuario(string nombreUsuario)
        {
            string consultaSQL = string.Format ("SELECT u.usuario, u.contraseña, u.fechaAlta, p.idPerfil, p.nombre" +
                "p.descripcion FROM usuario u JOIN perfil p ON u.idPerfil = p.idPerfil WHERE u.nombre ='{0}' ",nombreUsuario);

        }
        #endregion
        #region Mapeo

        #endregion
    }
}
