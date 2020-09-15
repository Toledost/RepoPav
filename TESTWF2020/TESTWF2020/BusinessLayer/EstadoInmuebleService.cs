using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class EstadoInmuebleService
    {
        private EstadoInmuebleDao estadoDao;
        public EstadoInmuebleService()
        {
            this.estadoDao = new EstadoInmuebleDao();
        }

        internal IList<EstadoInmueble> GetAll()
        {
            return estadoDao.GetAll();
        }
    }
}
