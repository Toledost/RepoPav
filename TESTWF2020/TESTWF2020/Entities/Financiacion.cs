using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.Entities
{
    public class Financiacion
    {
        public int IdFinanciacion { get; set; }
        public string Nombre { get; set; }
        public int PorcentajeAumento { get; set; }
        public int CantidadCuotas { get; set; }
    }
}
