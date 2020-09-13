using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class TipoInmuebleService
    {
        private TipoInmuebleDao tipoInmuebleDao;

        public TipoInmuebleService()
        {
            tipoInmuebleDao = new TipoInmuebleDao();
        }

        public IList<TipoInmueble> GetAll()
        {
            return tipoInmuebleDao.GetAll();
        }
    }
}
