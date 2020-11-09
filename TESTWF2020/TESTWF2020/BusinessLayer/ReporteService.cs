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

        internal DataTable GetCantConsultasByMedioConocimiento(Dictionary<string, object> diccionario)
        {
            return reporteDao.GetCantConsultasByMedioConocimiento(diccionario);
        }

        internal DataTable GetVentasPorMes(Dictionary<string, object> dict)
        {
            return reporteDao.GetVentasPorMes(dict);
        }

        internal DataTable GetDiasPorEstado(Dictionary<string, object> dict)
        {
            return reporteDao.GetDiasPorEstado(dict);
        }

        internal DataTable GetVentasPorFinanciacion(Dictionary<string, object> dict)
        {
            return reporteDao.GetVentasPorFinanciacion(dict);
        }

        internal DataTable GetVentasPorVendedor()
        {
            return reporteDao.GetVentasPorVendedor();
        }

        internal DataTable GetByFiltersRptConsultaMedioConocimiento(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetByFiltersRptConsultaMedioConocimiento(diccParametros);
        }

        internal DataTable GetEmpleadosPorAñoMes(Dictionary<string, object> dict)
        {
            return reporteDao.GetEmpleadosPorAñoMes(dict);
        }

        internal DataTable GetByFiltersRptCuota(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetByFiltersRptCuota(diccParametros);
        }

        internal DataTable GetCuotasByDireccion(Dictionary<string, object> diccParametros)
        {
            return reporteDao.GetCuotasByDireccion(diccParametros);
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
