using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.Entities
{
    public class Empleado
    {
        public int Legajo { get; set; }
        
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public Usuario Usuario { get; set; }

    }
}
