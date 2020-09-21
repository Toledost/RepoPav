using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    public class FinanciacionDao
    {
        public IList<Financiacion> GetAll()
        {
            IList<Financiacion> listaFinanciacion = new List<Financiacion>();

            string consultaSql = "SELECT " +
                "idFinanciacion, " +
                "nombre, " +
                "porcentajeAumento, " +
                "cantCuotas " +
                "FROM Financiacion " +
                "WHERE borrado = 0 ";

            DataManager dm = new DataManager();

            var resultado = dm.ConsultaSQL2(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    listaFinanciacion.Add(MapToEntity(row));
                }
            }

            return listaFinanciacion;
        }

        internal Financiacion GetById(int idFinanciacionElegida)
        {
            string consultaSql = "SELECT " +
                "idFinanciacion, " +
                "nombre, " +
                "porcentajeAumento, " +
                "cantCuotas " +
                "FROM Financiacion " +
                "WHERE borrado = 0 " +
                "AND idFinanciacion = @id";

            Dictionary<string, object> parametro = new Dictionary<string, object>
            {
                { "id", idFinanciacionElegida }
            };

            DataManager dm = new DataManager();

            var resultado = dm.ConsultaSQLConParametros2(consultaSql, parametro);

            return MapToEntity(resultado.Rows[0]);
        }

        public int Create(Financiacion financiacion)
        {
            string consultaSql = "INSERT INTO Financiacion " +
                "( nombre, " +
                "porcentajeAumento, " +
                "cantCuotas) " +
                "VALUES " +
                "(@nombre, " +
                "@porcAumento, " +
                "@cantCuotas) ";

            var parametros = CrearDiccionarioParametros(financiacion);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);

            return resultado;
        }

        public int Delete(int id)
        {
            string consultaSql = "UPDATE Financiacion " +
                "SET borrado = 1 " +
                "WHERE idFinanciacion = @id";

            Dictionary<string, object> parametro = new Dictionary<string, object>
            {
                { "id", id }
            };

            DataManager dm = new DataManager();

            return dm.EjecutarSQLConParametros2(consultaSql, parametro);
        }

        public int Update(Financiacion financiacion)
        {
            string consultaSql = "UPDATE Financiacion " +
                "SET nombre = @nombre, " +
                "porcentajeAumento = @porcAumento, " +
                "cantCuotas = @cantCuotas " +
                "WHERE idFinanciacion = @id ";

            DataManager dm = new DataManager();

            var parametros = CrearDiccionarioParametros(financiacion);

            return dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        private Dictionary<string, object> CrearDiccionarioParametros(Financiacion financiacion)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("id", financiacion.IdFinanciacion);
            parametros.Add("nombre", financiacion.Nombre);
            parametros.Add("porcAumento", financiacion.PorcentajeAumento);
            parametros.Add("cantCuotas", financiacion.CantidadCuotas);

            return parametros;
        }

        private Financiacion MapToEntity(DataRow row)
        {
            Financiacion financiacion = new Financiacion
            {
                IdFinanciacion = (int)row["idFinanciacion"],
                Nombre = row["nombre"].ToString(),
                PorcentajeAumento = (int)row["porcentajeAumento"],
                CantidadCuotas = (int)row["cantCuotas"]
            };

            return financiacion;
        }
    }
}
