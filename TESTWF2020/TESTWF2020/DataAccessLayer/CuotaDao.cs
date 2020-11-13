using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    public class CuotaDao
    {
        internal IList<Cuota> GetByVenta(int idVentaSeleccionada)
        {
            IList<Cuota> listaCuotas = new List<Cuota>();

            var dm = new DataManager();

            string consultaSQL = "SELECT " +
                "nroCuota, " +
                "c.idVenta, " +
                "fechaVencimiento, " +
                "fechaPago, " +
                "pagado " +
                "FROM cuota c " +
                "JOIN venta v on v.idVenta = c.idVenta " +
                "WHERE c.borrado = 0 " +
                $"AND v.idVenta = {idVentaSeleccionada}";

            var busqueda = dm.ConsultaSQL2(consultaSQL);

            if (busqueda.Rows.Count > 0)
            {
                foreach (DataRow row in busqueda.Rows)
                {
                    listaCuotas.Add(MapToEntity(row));
                }
            }
            return listaCuotas;

        }

        internal void RegistrarPagoCuota(int idVentaSeleccionada, IList<int> numeroCuotas)
        {
            var dm = new DataManager();

            string consultaSql = "UPDATE Cuota " +
                "SET pagado = 1, " +
                "fechaPago = GETDATE() " +
                "WHERE idVenta = @idVentaSeleccionada " +
                "AND @numeroCuotas LIKE ('%,'+CONVERT(varchar, nroCuota)+',%')";

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("idVentaSeleccionada", idVentaSeleccionada);
            parametros.Add("numeroCuotas", ","+string.Join(",", numeroCuotas)+",");

            dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        private Cuota MapToEntity(DataRow row)
        {
            Cuota cuota = new Cuota
            {
                NumeroCuota = (int)row["nroCuota"],
                FechaPago = row["fechaPago"] != DBNull.Value ? (DateTime)row["fechaPago"] : (DateTime?)null,
                FechaVencimiento = (DateTime)row["fechaVencimiento"],
                Pagado = (bool)row["pagado"]
            };

            return cuota;
        }
    }
}
