using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class ConsultaService
    {
        private ConsultaDao consultaDao;

        public ConsultaService()
        {
            consultaDao = new ConsultaDao(); 
        }

    }
}
