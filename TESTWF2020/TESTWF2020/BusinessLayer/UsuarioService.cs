using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class UsuarioService
    {
        private UsuarioDao usuarioDao;
        public UsuarioService()
        {
            usuarioDao = new UsuarioDao();
        }

        public Usuario ValidarUsuario(string usuario,string password)
        {
            var resUsuario  = usuarioDao.GetUsuario(usuario);
            if (resUsuario != null && password == resUsuario.Contraseña)
            {
                return resUsuario;
            }
            return null;
        }
    }
}
