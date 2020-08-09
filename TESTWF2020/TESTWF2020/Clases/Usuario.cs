﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.Clases
{
    class Usuario
    {
        #region private

        private int idUsuario;
        private string nUsuario;
        private string password;
        private string email;

        #endregion

        #region properties

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NUsuario { get => nUsuario; set => nUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }

        #endregion

        #region public Methods

        /// <summary>
        /// busca el usuario por nombre y clave y retorna el usuario encontrado, si no retorna null
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        public Usuario BuscarUsuario(string nombre, string clave)
        {
            string consulta = "";
            var resultado = Datos.Consultar(consulta);

            Usuario usuarioEncontrado = null;
            if (resultado.Rows.Count != 0)
            {
                usuarioEncontrado.IdUsuario = (int)resultado.Rows[0]["id_usuario"];
                usuarioEncontrado.NUsuario = resultado.Rows[0]["n_usuario"].ToString();
                usuarioEncontrado.Password = resultado.Rows[0]["password"].ToString();
                usuarioEncontrado.Email = resultado.Rows[0]["email"].ToString();
            }
            return usuarioEncontrado;
        }

        #endregion
    }
}
