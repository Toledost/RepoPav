using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class PerfilService
    {
        private PerfilDao perfilDao;

        public PerfilService()
        {
            perfilDao = new PerfilDao();
        }
        internal IList<Perfil> GetAll()
        {
            return perfilDao.GetAll();
        }
    }
}
