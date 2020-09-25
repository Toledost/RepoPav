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

        public IList<Consulta> GetAll()
        {
            return  consultaDao.GetAll();
        }

        internal void Delete(int idConsultaSeleccionada)
        {
            consultaDao.Delete(idConsultaSeleccionada);
        }

        public IList<Consulta> GetByFilters(Dictionary<string, object> diccParametros)
        {
            return consultaDao.GetByFilters(diccParametros);
        }

        public void Create(Consulta consulta)
        {
            return consultaDao.Create(consulta);
        }

        public void Update(Consulta consulta)
        {
            return consultaDao.Update(consulta);
        }
    }
}
