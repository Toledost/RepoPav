using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.Entities
{
    public class HistorialEstado
    {
        public Inmueble Inmueble { get; set; }
        public EstadoInmueble Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
