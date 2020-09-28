using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    class VentaDao
    {
        internal void Grabar(Venta venta)
        {
            string consultaSQL = "INSERT INTO Venta " +
                                " ([idVenta] , " +
                                //"[vendedor], " +
                                //"[legajoVendedor], " +
                                "[idInmueble], " +
                                "[fechaVenta], " +
                                "[fechaEntrega], " +
                                "[dniCliente], " +
                                "[montoTotal], " +
                                "[montoCuota], " +
                                "[esFinanciada]) " +
                                //"[financiacion]) " +
                                "VALUES " +
                                "(@idVenta, " +
                                //"@vendedor, " +
                                //"@legajoVendedor, " +
                                "@idInmueble, " +
                                "@fechaVenta, " +
                                "@fechaEntrega, " +
                                "@dniCliente, " +
                                "@montoTotal, " +
                                "@montoCuota, " +
                                "@esFinanciada) ";
                                //"@financiacion) ";
            var parametros = CrearDiccionario(venta);

            DataManager dm = new DataManager();
            dm.EjecutarSQLConParametros2(consultaSQL, parametros);

        }

        private Dictionary<string, object> CrearDiccionario(Venta venta)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("idVenta", venta.IdVenta );
            parametros.Add("fechaVenta", venta.FechaVenta);
            parametros.Add("fechaEntrega", venta.FechaEntrega);
            //parametros.Add("financiacion", venta.Financiacion);
            parametros.Add("idInmueble", venta.Inmueble.Id);
            //parametros.Add("legajoVendedor", venta.Vendedor.Legajo);
            parametros.Add("dniCliente", venta.Cliente.Dni);
            parametros.Add("esFinanciada", venta.EsFinanciada);
            parametros.Add("montoTotal", venta.MontoTotal); 
            parametros.Add("montoCuota", venta.MontoCuota);

            return parametros;
        }
    }
}
