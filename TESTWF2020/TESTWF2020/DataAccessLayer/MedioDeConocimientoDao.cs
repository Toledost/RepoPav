using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    public class MedioDeConocimientoDao
    {
        public IList<MedioDeConocimiento> GetAll()
        {
            var medios = new List<MedioDeConocimiento>();

            string consultaSQL = string.Format("SELECT idMedioConocimiento, nombre, descripcion FROM MedioConocimiento WHERE borrado = 0");

            DataManager dm = new DataManager();

            var resultado = dm.ConsultaSQL2(consultaSQL);

            foreach (DataRow row in resultado.Rows)
            {
                medios.Add(MapToEntity(row));
            }                

            return medios;
        }

        private MedioDeConocimiento MapToEntity(DataRow row)
        {
            MedioDeConocimiento medio = new MedioDeConocimiento()
            {
                Id = (int)row["idMedioConocimiento"],
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),
               
            };
            return medio;
        }
    }
}
