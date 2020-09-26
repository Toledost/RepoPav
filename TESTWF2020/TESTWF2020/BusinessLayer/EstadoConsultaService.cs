using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;
using TESTWF2020.DataAccessLayer;

namespace TESTWF2020.BusinessLayer
{
    public class EstadoConsultaService
    {
        private EstadoConsultaDao estadoConsultaDao;

        public EstadoConsultaService()
        {
            estadoConsultaDao = new EstadoConsultaDao();
        }

        public IList<EstadoConsulta> GetAll()
        {
            return estadoConsultaDao.GetAll();
        }
    }
}
