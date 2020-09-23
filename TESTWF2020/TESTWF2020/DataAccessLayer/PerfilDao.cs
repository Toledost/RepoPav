using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    public class PerfilDao
    {
        internal IList<Perfil> GetAll()
        {
            IList<Perfil> listaPerfiles = new List<Perfil>();
            string consultaSQL = "SELECT idPerfil," +
                                "nombre," +
                                "descripcion " +
                                "FROM Perfil " +
                                "WHERE borrado = 0 ";
            DataManager dm = new DataManager();
            var resultadoSQL = dm.ConsultaSQL2(consultaSQL);
            if (resultadoSQL.Rows.Count >0)
            {
                foreach (DataRow row in resultadoSQL.Rows)
                {
                    listaPerfiles.Add(MapToEntity(row));
                }
            }
            return listaPerfiles;
        }

        private Perfil MapToEntity(DataRow row)
        {
            Perfil perfil = new Perfil
            {
                IdPerfil = (int)row["idPerfil"],
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString()
            };
            return perfil;
        }
    }
}
