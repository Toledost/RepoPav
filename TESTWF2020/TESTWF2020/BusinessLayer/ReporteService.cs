using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;

namespace TESTWF2020.BusinessLayer
{
    public class ReporteService
    {
        private ReporteDao reporteDao;

        public ReporteService()
        {
            reporteDao = new ReporteDao();
        }

        internal DataTable GetByFiltersRptInmueble(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetByFiltersRptInmueble(diccParametros);
        }

        internal DataTable GetByFiltersRptVenta(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetByFiltersRptVenta(diccParametros);
        }

        internal DataTable GetVentasPorMes()
        {
            return reporteDao.GetVentasPorMes();
        }
    }
}
