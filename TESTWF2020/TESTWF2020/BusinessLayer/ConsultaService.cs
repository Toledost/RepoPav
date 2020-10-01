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

        internal void Delete(int idConsultaSeleccionada, Usuario usuarioLogueado)
        {
            consultaDao.Delete(idConsultaSeleccionada, usuarioLogueado);
        }

        public IList<Consulta> GetByFilters(Dictionary<string, object> diccParametros)
        {
            return consultaDao.GetByFilters(diccParametros);
        }

        public void Create(Consulta consulta, Usuario usuarioLogueado)
        {
            consultaDao.Create(consulta, usuarioLogueado);
        }

        public void Update(Consulta consulta, Usuario usuarioLogueado)
        {
            consultaDao.Update(consulta, usuarioLogueado);
        }

        public Consulta GetById(int idConsultaSeleccionada)
        {
            return consultaDao.GetById(idConsultaSeleccionada);
        }
    }
}
