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

        public Usuario ValidarUsuario(string usuario, string password)
        {
            var resUsuario  = usuarioDao.GetUsuario(usuario);
            if (resUsuario != null && password == resUsuario.Contraseña)
            {
                return resUsuario;
            }
            return null;
        }

        internal void Insert(Usuario user)
        {
            usuarioDao.Insert(user);
        }

        internal IList<Usuario> GetAll()
        {
            return usuarioDao.GetAll();
        }

        internal IList<Usuario> GetByFilters(Dictionary<string,object> dicc)
        {
            return usuarioDao.GetByFilters(dicc);
        }

        internal Usuario GetUsuario(string nombreUsuario, bool buscarBorrado = false)
        {
            return usuarioDao.GetUsuario(nombreUsuario, buscarBorrado);
        }

        internal void UpDate(Usuario user)
        {
            usuarioDao.UpDate(user);
        }

        internal void Delete(string nombreUsuarioSeleccionado)
        {
            usuarioDao.Delete(nombreUsuarioSeleccionado);
        }

        internal void Recuperar(string nombreUsuarioSeleccinado)
        {
            usuarioDao.Recuperar(nombreUsuarioSeleccinado);
        }
    }
}
