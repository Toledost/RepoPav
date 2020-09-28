using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.DataAccessLayer;
using TESTWF2020.Entities;

namespace TESTWF2020.BusinessLayer
{
    public class InmuebleService
    {
        private InmuebleDao inmuebleDao;
        public InmuebleService()
        {
            inmuebleDao = new InmuebleDao();
        }

        public IList<Inmueble> GetByFilters(Dictionary<string, object> parametros)
        {
            return inmuebleDao.GetByFilters(parametros);
        }

        internal void Create(Inmueble inmueble, EstadoInmueble estado)
        {
            inmuebleDao.Create(inmueble, estado);
        }

        internal void Delete(int id)
        {
            inmuebleDao.Delete(id);
        }



        internal Inmueble GetById(int idInmueble)
        {
            return inmuebleDao.GetById(idInmueble);
        }

        internal void Update(Inmueble inmueble, bool esEstadoNuevo, EstadoInmueble estado)
        {
            inmuebleDao.Update(inmueble, esEstadoNuevo, estado);
        }
    }
}
