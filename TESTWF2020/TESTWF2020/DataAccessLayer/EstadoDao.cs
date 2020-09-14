using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    public class EstadoDao
    {
        internal IList<EstadoInmueble> GetAll()
        {
            IList<EstadoInmueble> listaEstados = new List<EstadoInmueble>();
            var dm = new DataManager();

            string consultaSQL = "SELECT " +
                "idEstadoInmueble, " +
                "nombre, " +
                "descripcion " +
                "FROM EstadoInmueble " +
                "WHERE borrado = 0";


            var busqueda = dm.ConsultaSQL2(consultaSQL);

            if (busqueda.Rows.Count > 0)
            {
                foreach (DataRow row in busqueda.Rows)
                {
                    listaEstados.Add(MapToEntity(row));

                }
            }
            return listaEstados;
        }

        private EstadoInmueble MapToEntity(DataRow row)
        {
            EstadoInmueble estadoInmueble = new EstadoInmueble
            {
                Id = (int)row["idEstadoInmueble"],
                Descripcion = row["descripcion"].ToString(),
                Nombre = row["nombre"].ToString()
            };
            return estadoInmueble;
        }
    }
}
