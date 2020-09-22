using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;
using System.Runtime.CompilerServices;

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

        internal MedioDeConocimiento GetById(int idMedio, bool borrado = false)
        {
            MedioDeConocimiento resultado = null;
            var dm = new DataManager();

            string consultaSql = "SELECT " +
                "idMedioConocimiento, " +
                "nombre, " +
                "descripcion " +  
                "FROM MedioConocimiento " +
                $"WHERE borrado = {(borrado ? 1 : 0)} " +
                $"AND idMedioConocimiento = {idMedio}";

            var busqueda = dm.ConsultaSQL2(consultaSql);
            if (busqueda.Rows.Count > 0)
            {
                resultado = MapToEntity(busqueda.Rows[0]);
            }
            return resultado;
        }

        internal void Delete(int idmedioSeleccionado)
        {
            var parametros = new Dictionary<string, object>();

            string consultaSql = "UPDATE MedioConocimiento SET borrado = 1 WHERE idMedioConocimiento = @id ";

            parametros.Add("id", idmedioSeleccionado);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        internal void Update(MedioDeConocimiento medio)
        {
            string consultaSql = "UPDATE MedioConocimiento " +
                "SET " +
                "[nombre] = @nombre" +
                ",[descripcion] = @descripcion " +
                $"WHERE idMedioConocimiento = {medio.Id}";

            var parametros = new Dictionary<string, object>();

            parametros.Add("nombre", medio.Nombre);
            parametros.Add("descripcion", medio.Descripcion);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        internal void Create(MedioDeConocimiento medio)
        {
            string consultaSql = "INSERT INTO MedioConocimiento " +
                "([nombre]" +
                ",[descripcion]) " +
                "VALUES " +
                "(@nombre" +
                ",@descripcion) ";

            var parametros = new Dictionary<string, object>();

            parametros.Add("nombre", medio.Nombre);
            parametros.Add("descripcion", medio.Descripcion);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
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
