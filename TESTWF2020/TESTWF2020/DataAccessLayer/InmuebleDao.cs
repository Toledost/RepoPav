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
    public class InmuebleDao
    {
        public IList<Inmueble> GetByFilters(Dictionary<string, object> parametros)
        {
            var inmuebles = new List<Inmueble>();

            string consultaSql = "SELECT " +
                "i.[idInmueble]" +
                ", i.[calle]" +
                ", i.[calleNro]" +
                ", i.[m2]" +
                ", i.[cantBaños]" +
                ", i.[cantHabitaciones]" +
                ", i.[idTipoInmueble]" +
                ", i.[descripcion]" +
                ", i.[montoAlquiler]" +
                ", i.[montoVenta]" +
                ", t.[idTipoInmueble]" +
                ", t.[nombre]" +
                ", t.[descripcion] AS descripcionTipoInmueble " +
                "FROM Inmueble i " +
                "INNER JOIN TipoInmueble t ON i.idTipoInmueble = t.idTipoInmueble " +
                "WHERE i.borrado = 0";

            consultaSql = AgregarParametros(parametros, consultaSql);

            DataManager dm = new DataManager();
            //dm.Open();
            //var resultado = dm.ConsultaSQLConParametros(consultaSql, parametros);
            var resultado = dm.ConsultaSQLConParametros2(consultaSql, parametros);
            foreach (DataRow row in resultado.Rows)
                inmuebles.Add(MapToEntity(row));

            //dm.Close();

            return inmuebles;
        }

        internal Inmueble GetById(int idInmueble)
        {
            Inmueble resultado = null;
            var dm = new DataManager();

            string consultaSql = "SELECT " +
                "i.[idInmueble]" +
                ", i.[calle]" +
                ", i.[calleNro]" +
                ", i.[m2]" +
                ", i.[cantBaños]" +
                ", i.[cantHabitaciones]" +
                ", i.[idTipoInmueble]" +
                ", i.[descripcion]" +
                ", i.[montoAlquiler]" +
                ", i.[montoVenta]" +
                ", t.[idTipoInmueble]" +
                ", t.[nombre]" +
                ", t.[descripcion] AS descripcionTipoInmueble " +
                "FROM Inmueble i " +
                "INNER JOIN TipoInmueble t ON i.idTipoInmueble = t.idTipoInmueble " +
                "WHERE i.borrado = 0 " +
                $"AND i.idInmueble = {idInmueble}";

            var busqueda = dm.ConsultaSQL2(consultaSql);
            if (busqueda.Rows.Count > 0)
            {
                resultado = MapToEntity(busqueda.Rows[0]);
            }
            return resultado;
        }

        public void Create(Inmueble inmueble)
        {
            string consultaSql = "INSERT INTO Inmueble " +
                "([calle]" +
                ",[calleNro]" +
                ",[m2]" +
                ",[cantBaños]" +
                ",[cantHabitaciones]" +
                ",[idTipoInmueble]" +
                ",[descripcion]" +
                ",[montoAlquiler]" +
                ",[montoVenta]) " +
                "VALUES " +
                "(@calle" +
                ",@calleNro" +
                ",@m2" +
                ",@cantBaños" +
                ",@cantHabitaciones" +
                ",@idTipoInmueble" +
                ",@descripcion" +
                ",@montoAlquiler" +
                ",@montoVenta) ";

            var parametros = new Dictionary<string, object>();

            parametros.Add("calle", inmueble.Calle);
            parametros.Add("idTipoInmueble", inmueble.TipoInmueble.Id);
            parametros.Add("calleNro", inmueble.CalleNumero);
            parametros.Add("m2", inmueble.MetrosCuadrados);
            parametros.Add("cantBaños", inmueble.Baños);
            parametros.Add("cantHabitaciones", inmueble.Habitaciones);
            parametros.Add("descripcion", inmueble.Descripcion);
            parametros.Add("montoAlquiler", inmueble.MontoAlquiler);
            parametros.Add("montoVenta", inmueble.MontoVenta);



            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
                
        }

        public void Update(Inmueble inmueble, bool cambioEstado)
        {
            string consultaSql = "UPDATE Inmueble " +
                "SET " +
                "[calle] = @calle" +
                ",[calleNro] = @calleNro" +
                ",[m2] = @m2" +
                ",[cantBaños] = @cantBaños" +
                ",[cantHabitaciones] = @cantHabitaciones" +
                ",[idTipoInmueble] = @idTipoInmueble" +
                ",[descripcion] = @descripcion" +
                ",[montoAlquiler] = @montoAlquiler" +
                ",[montoVenta] = @montoVenta " +
                "WHERE idInmueble = @id ";

            if (cambioEstado)
            {
                consultaSql += " UPDATE HistorialEstado SET fechaFin = GetUTCDATE() " +
                    "WHERE idInmueble = @id ";
            }

            var parametros = new Dictionary<string, object>();

            parametros.Add("calle", inmueble.Calle);
            parametros.Add("idTipoInmueble", inmueble.TipoInmueble.Id);
            parametros.Add("calleNro", inmueble.CalleNumero);
            parametros.Add("m2", inmueble.MetrosCuadrados);
            parametros.Add("cantBaños", inmueble.Baños);
            parametros.Add("cantHabitaciones", inmueble.Habitaciones);
            parametros.Add("descripcion", inmueble.Descripcion);
            parametros.Add("montoAlquiler", inmueble.MontoAlquiler);
            parametros.Add("montoVenta", inmueble.MontoVenta);
            parametros.Add("id", inmueble.Id);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);

        }

        public void Delete(int id)
        {
            var parametros = new Dictionary<string, object>();

            string consultaSql = "UPDATE Inmueble SET borrado = 1 WHERE idInmueble = @id " +
                "UPDATE HistorialEstado SET borrado = 1 WHERE idInmueble = @id";

            parametros.Add("id", id);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        #region metodos privados

        /// <summary>
        /// Agrega a la consulta SQL los parametros del diccionario
        /// </summary>
        /// <param name="parametros"></param>
        /// <param name="consultaSql"></param>
        /// <returns></returns>
        private string AgregarParametros(Dictionary<string, object> parametros, string consultaSql)
        {
            if (parametros.ContainsKey("id"))
                consultaSql += " AND (i.idInmueble LIKE =@id) ";

            if (parametros.ContainsKey("calle"))
                consultaSql += " AND (i.calle LIKE '%' + @calle + '%') ";

            if (parametros.ContainsKey("baños"))
                consultaSql += " AND (i.cantBaños = @baños) ";

            if (parametros.ContainsKey("habitaciones"))
                consultaSql += " AND (i.cantHabitaciones = @habitaciones) ";

            if (parametros.ContainsKey("mtsMin"))
                consultaSql += " AND (i.m2 >= @mtsMin) ";

            if (parametros.ContainsKey("mtsMax"))
                consultaSql += " AND (i.m2 <= @mtsMax) ";

            if (parametros.ContainsKey("montoAlqMin"))
                consultaSql += " AND (i.montoAlquiler >= @montoAlqMin) ";

            if (parametros.ContainsKey("montoAlqMax"))
                consultaSql += " AND (i.montoAlquiler <= @montoAlqMax) ";

            if (parametros.ContainsKey("montoVtaMin"))
                consultaSql += " AND (i.montoVenta >= @montoVtaMin) ";

            if (parametros.ContainsKey("montoVtaMax"))
                consultaSql += " AND (i.montoVenta <= @montoVtaMax) ";

            if (parametros.ContainsKey("tipoInmueble"))
                consultaSql += " AND (i.idTipoInmueble = @tipoInmueble) ";

            return consultaSql;
        }

        #endregion

        #region Mapeo
        private Inmueble MapToEntity(DataRow row)
        {
            Inmueble inmueble = new Inmueble
            {
                Id = (int)row["idInmueble"],
                Calle = row["calle"].ToString(),
                CalleNumero = (int)row["calleNro"],
                MetrosCuadrados = (double)row["m2"],
                Baños = (int)row["cantBaños"],
                Habitaciones = (int)row["cantHabitaciones"],
                Descripcion = row["descripcion"].ToString(),
                MontoAlquiler = (int)row["montoalquiler"],
                MontoVenta = (int)row["montoventa"],
                TipoInmueble = new TipoInmueble()
                {
                    Id = (int)row["idTipoInmueble"],
                    Nombre = row["nombre"].ToString(),
                    Descripcion = row["descripcionTipoInmueble"].ToString()
                }
            };
            return inmueble;
        }
        #endregion
    }
}
