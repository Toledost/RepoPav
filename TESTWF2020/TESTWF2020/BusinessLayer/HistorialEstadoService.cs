using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class HistorialEstadoService
    {
        private HistorialEstadoDao historialDao;

        public HistorialEstadoService()
        {
            this.historialDao = new HistorialEstadoDao();   
        }

        public IList<HistorialEstado> GetHistorialEstadoByInmuebleID(int idInmueble)
        {
            return historialDao.GetHistorialEstadoByInmuebleID(idInmueble);
        }
    }
}
