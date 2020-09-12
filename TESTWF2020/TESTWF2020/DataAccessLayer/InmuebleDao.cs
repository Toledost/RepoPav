using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.DataAccessLayer
{
    public class InmuebleDao
    {
        public IList<Inmueble> GetByFilters(Dictionary<string, object> parametros)
        {
            var inmuebles = new IList<Inmueble>();

            string consultaSql = "SELECT * FROM Inmueble";

            if (parametros.ContainsKey("idPerfil"))
                consultaSql += " AND (u.id_perfil = @idPerfil) ";

            if (parametros.ContainsKey("usuario"))
                consultaSql += " AND (u.usuario LIKE '%' + @usuario + '%') ";

            //var resultado = DBHelper.GetDBHelper().ConsultaSQLConParametros(strSql, parametros);
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
