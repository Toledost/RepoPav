using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.Entities
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaAlta { get; set; }
        public Perfil Perfil { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
