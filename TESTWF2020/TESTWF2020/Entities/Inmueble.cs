using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.Entities
{
    public class Inmueble
    {
        public int Id { get; set; }
        public string TipoInmueble { get; set; }
        public string Calle { get; set; }
        public int CalleNumero { get; set; }
        public int MetrosCuadrados { get; set; }
        public int Baños { get; set; }
        public int Habitaciones { get; set; }
        public int MontoAlq { get; set; }
        public int MontoVta { get; set; }
        public string Descripcion { get; set; }



    }
}
