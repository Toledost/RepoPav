using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class VentaService
    {
        private VentaDao ventaDao;
        public VentaService()
        {
            ventaDao = new VentaDao();
        }
        internal bool Grabar(Venta venta)
        {
            return ventaDao.Grabar(venta);
        }
    }
}
