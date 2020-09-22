using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class MedioDeConocimientoService
    {

        private MedioDeConocimientoDao medioDeConocimientoDao;
        public MedioDeConocimientoService()
        {
            medioDeConocimientoDao = new MedioDeConocimientoDao();
        }

        public IList<MedioDeConocimiento> GetAll()
        {
            return medioDeConocimientoDao.GetAll();
        }
     
    }
}
