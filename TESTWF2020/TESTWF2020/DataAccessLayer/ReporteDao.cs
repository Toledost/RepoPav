using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.DataAccessLayer
{
    class ReporteDao
    {
        internal DataTable GetByFilters(Dictionary<string, object> diccParametros)
        {
            string consultaSQL = "SELECT HistorialEstado.fechaInicio, " +
                "HistorialEstado.idEstadoInmueble, " +
                "HistorialEstado.fechaFin, " +
                "EstadoInmueble.nombre AS Estado,  " +
                "Inmueble.idInmueble, " +
                "Inmueble.calle, " +
                "Inmueble.calleNro, " +
                "DATEDIFF(day, HistorialEstado.fechaInicio, HistorialEstado.fechaFin) AS Dias " +
                "FROM EstadoInmueble " +
                "INNER JOIN HistorialEstado ON EstadoInmueble.idEstadoInmueble = HistorialEstado.idEstadoInmueble " +
                "INNER JOIN Inmueble ON HistorialEstado.idInmueble = Inmueble.idInmueble ";

            var dm = new DataManager();
            consultaSQL = AgregarParametros(diccParametros,consultaSQL);
            var busqueda = dm.ConsultaSQLConParametros2(consultaSQL, diccParametros);

            return busqueda;
        }

        private string AgregarParametros(Dictionary<string, object> diccParametros, string consultaSQL)
        {
            if (diccParametros.ContainsKey("idInmueble"))
                consultaSQL += " AND (Inmueble.idInmueble =@idInmueble) ";

            if (diccParametros.ContainsKey("fechaDesde"))
                consultaSQL += " AND (HistorialEstado.fechaInicio BETWEEN @fechaDesde AND @fechaHasta) ";

            return consultaSQL;
        }
    }
}
