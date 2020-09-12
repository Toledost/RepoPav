using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    public class InmuebleDao
    {
        public IList<Inmueble> GetByFilters(Dictionary<string, object> parametros)
        {
            var inmuebles = new List<Inmueble>();

            string consultaSql = "SELECT * FROM Inmueble WHERE borrado = 0";

            if (parametros.ContainsKey("calle"))
                consultaSql += " AND (calle LIKE '%' + @calle + '%') ";

            if (parametros.ContainsKey("baños"))
                consultaSql += " AND (baños = @baños) ";

            if (parametros.ContainsKey("habitaciones"))
                consultaSql += " AND (habitaciones = @habitaciones) ";

            if (parametros.ContainsKey("mtsMin"))
                consultaSql += " AND (m2 >= @mtsMin) ";

            if (parametros.ContainsKey("mtsMax"))
                consultaSql += " AND (m2 <= @mtsMax) ";

            if (parametros.ContainsKey("montoAlqMin"))
                consultaSql += " AND (montoAlquiler >= @montoAlqMin) ";

            if (parametros.ContainsKey("montoAlqMax"))
                consultaSql += " AND (montoAlquiler <= @montoAlqMax) ";

            if (parametros.ContainsKey("montoVtaMin"))
                consultaSql += " AND (montoVenta >= @montoVtaMin) ";

            if (parametros.ContainsKey("montoVtaMax"))
                consultaSql += " AND (montoVenta <= @montoVtaMax) ";
          
            DataManager dm = new DataManager();
            dm.Open();
            var resultado = dm.ConsultaSQLConParametros(consultaSql, parametros);

            foreach (DataRow row in resultado.Rows)
                inmuebles.Add(MapToEntity(row));

            dm.Close();

            return inmuebles;
        }

        #region Mapeo
        private Inmueble MapToEntity(DataRow row)
        {
            Inmueble usuario = new Inmueble
            {
                
            };
            return usuario;
        }
        #endregion
    }
}
