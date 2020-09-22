using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class TipoTransaccionService
    {
        private TipoTransaccionDao tipoTransaccionDao;
        public TipoTransaccionService()
        {
            this.tipoTransaccionDao = new TipoTransaccionDao();
        }
        internal IList<TipoTransaccion> GetAll()
        {
            return tipoTransaccionDao.GetAll();
        }
    }
}
