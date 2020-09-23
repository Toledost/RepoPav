using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;
using System.Data;

namespace TESTWF2020.DataAccessLayer
{
    public class EstadoConsultaDao
    {
        internal IList<EstadoConsulta> GetAll()
        {
            var estadoConsulta = new List<EstadoConsulta>();

            string consultaSql = "SELECT " +
                "idEstadoConsulta, " +
                "nombre, " +
                "descripcion " +
                "FROM EstadoConsulta " +
                "WHERE borrado = 0";

            DataManager dm = new DataManager();

            var resultado = dm.ConsultaSQL2(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    estadoConsulta.Add(MapToEntity(row));
                }
                return estadoConsulta;
            }

            return null;           
        }

        private EstadoConsulta MapToEntity(DataRow row)
        {
            EstadoConsulta estadoConsulta = new EstadoConsulta
            {
                Id = (int)row["idEstadoConsulta"],
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),

            };
            return estadoConsulta;
        }
    }
}
