using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class FinanciacionService
    {
        private FinanciacionDao financiacionDao;

        public FinanciacionService()
        {
            financiacionDao = new FinanciacionDao();
        }

        public IList<Financiacion> GetAll()
        {
            return financiacionDao.GetAll();
        }

        public int Create(Financiacion financiacion)
        {
            return financiacionDao.Create(financiacion);
        }

        public int Delete(int id)
        {
            return financiacionDao.Delete(id);
        }

        public int Update(Financiacion financiacion)
        {
            return financiacionDao.Update(financiacion);
        }

        internal Financiacion GetById(int idFinanciacionElegida)
        {
            return financiacionDao.GetById(idFinanciacionElegida);
        }

        internal IList<Financiacion> GetByFilters(Dictionary<string, object> dicc)
        {
            return financiacionDao.GetByFilters(dicc);
        }
    }
}
