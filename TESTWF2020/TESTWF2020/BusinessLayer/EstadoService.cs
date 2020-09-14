using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class EstadoService
    {
        private EstadoDao estadoDao;
        public EstadoService()
        {
            this.estadoDao = new EstadoDao();
        }

        internal IList<EstadoInmueble> GetAll()
        {
            return estadoDao.GetAll();
        }
    }
}
