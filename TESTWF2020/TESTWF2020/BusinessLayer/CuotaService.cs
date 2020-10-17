using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class CuotaService
    {
        private CuotaDao cuotaDao;
        public CuotaService()
        {
            this.cuotaDao = new CuotaDao();
        }

        internal IList<Cuota> GetByVenta(int idVentaSeleccionada)
        {
            return cuotaDao.GetByVenta(idVentaSeleccionada);
        }

        internal void RegistrarPagoCuota(int idVentaSeleccionada, IList<int> numeroCuotas)
        {
            cuotaDao.RegistrarPagoCuota(idVentaSeleccionada, numeroCuotas);
        }
    }
}
