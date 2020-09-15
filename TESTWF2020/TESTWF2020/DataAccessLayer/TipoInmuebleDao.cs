using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    public class TipoInmuebleDao
    {
        public IList<TipoInmueble> GetAll()
        {
            var resultado = new List<TipoInmueble>();

            string consultaSql = "SELECT * FROM TipoInmueble WHERE borrado = 0";

            var dm = new DataManager();

            var resultadoBusqueda = dm.ConsultaSQL2(consultaSql);

            foreach (DataRow row in resultadoBusqueda.Rows)
            {
                resultado.Add(MapToEntity(row));
            }

            return resultado;
        }

        private TipoInmueble MapToEntity(DataRow row)
        {
            TipoInmueble tipoInmueble = new TipoInmueble
            {
                Id = (int)row["idTipoInmueble"],
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString()
            };

            return tipoInmueble;
        }
    }
}
