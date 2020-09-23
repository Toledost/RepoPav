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

        internal MedioDeConocimiento GetById(int idMedioSeleccionado, bool borrado = false)
        {
            return medioDeConocimientoDao.GetById(idMedioSeleccionado, borrado);
        }

        internal void Create(MedioDeConocimiento medio)
        {
            medioDeConocimientoDao.Create(medio);
        }

        internal void Update(MedioDeConocimiento medio)
        {
            medioDeConocimientoDao.Update(medio);
        }

        internal void Delete(int medioSeleccionado)
        {
            medioDeConocimientoDao.Delete(medioSeleccionado);
        }
    }
}
