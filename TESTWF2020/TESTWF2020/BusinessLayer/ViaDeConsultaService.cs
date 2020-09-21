using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class ViaDeConsultaService
    {
        private ViaDeConsultaDao viaDeConsultaDao;

        public ViaDeConsultaService()
        {
            viaDeConsultaDao = new ViaDeConsultaDao();
        }
        internal IList<ViaDeConsulta> GetAll()
        {
            return viaDeConsultaDao.GetAll();
        }
    }
}
