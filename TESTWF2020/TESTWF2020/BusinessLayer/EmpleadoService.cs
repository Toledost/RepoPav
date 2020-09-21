using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    class EmpleadoService
    {
        public EmpleadoDao empleadoDao;

        public EmpleadoService()
        {
            empleadoDao = new EmpleadoDao();
        }

        public IList<Empleado> GetByFilters(Dictionary<string, object> parametros)
        {
            return empleadoDao.GetByFilters(parametros);
        }

        public void Delete(int legajoSeleccionado)
        {
            empleadoDao.Delete(legajoSeleccionado);
        }
    }
}
