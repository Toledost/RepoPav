using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.Entities
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Usuario UsuarioVendedor { get; set; }
        public Inmueble Inmueble { get; set; }
        public DateTime FechaVenta { get; set; }
        public DateTime FechaEntrega { get; set; }
        public Cliente Cliente { get; set; }
        public int MontoTotal { get; set; }
        public int MontoCuota { get; set; }
        public bool EsFinanciada { get; set; }
        public Financiacion Financiacion { get; set; }
    }
}
