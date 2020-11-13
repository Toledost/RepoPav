using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    public class TipoTransaccionDao
    {
        internal IList<TipoTransaccion> GetAll()
        {
            IList<TipoTransaccion> listaTipoTransaccion = new List<TipoTransaccion>();

            string consultaSql = "SELECT " +
                "idTipoTransaccion, " +
                "nombre, " +
                "descripcion " +
                "FROM TipoTransaccion " +
                "WHERE Borrado = 0";

            DataManager dm = new DataManager();

            var resultado = dm.ConsultaSQL2(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    listaTipoTransaccion.Add(MapToEntity(row));
                }
            }

            return listaTipoTransaccion;
        }

        private TipoTransaccion MapToEntity(DataRow row)
        {
            TipoTransaccion tipoTransaccion = new TipoTransaccion
            {
                Id = (int)row["idTipoTransaccion"],
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString()
            };

            return tipoTransaccion;
        }
    }
}
