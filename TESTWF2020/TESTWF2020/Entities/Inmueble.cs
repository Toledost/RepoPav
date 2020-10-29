using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.Entities
{
    public class Inmueble
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public int CalleNumero { get; set; }
        public double MetrosCuadrados { get; set; }
        public int Baños { get; set; }
        public int Habitaciones { get; set; }
        public int MontoAlquiler { get; set; }
        public int MontoVenta { get; set; }
        public string Descripcion { get; set; }
        public TipoInmueble TipoInmueble { get; set; }

        public string DireccionCompleta => $"{Calle} {CalleNumero}";
    }
}
