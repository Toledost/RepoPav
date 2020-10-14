using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.Entities
{
    public class Cuota
    {
        public int NumeroCuota { get; set; }
        public Venta Venta { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? FechaPago { get; set; }
        public bool Pagado { get; set; }
    }
}
