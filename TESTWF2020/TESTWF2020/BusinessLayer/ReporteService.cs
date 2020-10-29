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

        internal DataTable GetByFiltersRptConsultaInmueble(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetByFiltersRptConsultaInmueble(diccParametros);
        }

        internal DataTable GetConsultaInmuebleEstadistica(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetConsultaInmuebleEstadistica(diccParametros);
        }

        internal DataTable GetCantConsultasByMedioConocimiento()
        {
            return reporteDao.GetCantConsultasByMedioConocimiento();
        }

        internal DataTable GetVentasPorMes()
        {
            return reporteDao.GetVentasPorMes();
        }

        internal DataTable GetDiasPorEstado()
        {
            return reporteDao.GetDiasPorEstado();
        }

        internal DataTable GetVentasPorFinanciacion()
        {
            return reporteDao.GetVentasPorFinanciacion();
        }

        internal DataTable GetVentasPorVendedor()
        {
            return reporteDao.GetVentasPorVendedor();
        }

        internal DataTable GetByFiltersRptConsultaMedioConocimiento(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetByFiltersRptConsultaMedioConocimiento(diccParametros);
        }

        internal DataTable GetEmpleadosPorAñoMes()
        {
            return reporteDao.GetEmpleadosPorAñoMes();
        }

        internal DataTable GetByFiltersRptCuota(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetByFiltersRptCuota(diccParametros);
        }

        internal DataTable GetCuotasByDireccion()
        {
            return reporteDao.GetCuotasByDireccion();
        }

        internal DataTable GetByFiltersRptEmpleado(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetByFiltersRptEmpleado(diccParametros);
        }

        internal DataTable GetByFiltersRptFinanciacion(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetByFiltersRptFinanciacion(diccParametros);
        }

        internal DataTable GetByFiltersRptVendedor(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetByFiltersRptVendedor(diccParametros);
        }
    }
}
