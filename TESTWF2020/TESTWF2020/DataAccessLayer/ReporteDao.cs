﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.DataAccessLayer
{
    class ReporteDao
    {
        internal DataTable GetByFiltersRptInmueble(Dictionary<string, object> diccParametros)
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

        internal DataTable GetEmpleadosPorAñoMes()
        {
            string consultaSql = "SELECT Usuario.nombre AS Usuario, " +
                "Usuario.fechaAlta " +
                "FROM Empleado " +
                "INNER JOIN Usuario ON Empleado.usuario = Usuario.nombre " +
                "INNER JOIN Perfil ON Usuario.idPerfil = Perfil.idPerfil " +
                "GROUP BY Usuario.nombre,Usuario.fechaAlta ";

            var dm = new DataManager();
            var busqueda = dm.ConsultaSQL2(consultaSql);

            return busqueda;
        }

        internal DataTable GetDiasPorEstado()
        {
            string consultaSql = "SELECT Inmueble.idInmueble,  " +
                "EstadoInmueble.nombre AS Estado, " +
                "DATEDIFF(day, HistorialEstado.fechaInicio,HistorialEstado.fechaFin) AS Dias " +
                "FROM EstadoInmueble " +
                "INNER JOIN HistorialEstado ON EstadoInmueble.idEstadoInmueble = HistorialEstado.idEstadoInmueble " +
                "INNER JOIN Inmueble ON HistorialEstado.idInmueble = Inmueble.idInmueble " +
                "GROUP BY Inmueble.idInmueble, " +
                "HistorialEstado.fechaInicio, " +
                "HistorialEstado.fechaFin, " +
                "HistorialEstado.idEstadoInmueble, " +
                "EstadoInmueble.nombre";

            var dm = new DataManager();
            var busqueda = dm.ConsultaSQL2(consultaSql);

            return busqueda;
        }

        internal DataTable GetByFiltersRptEmpleado(Dictionary<string, object> diccParametros)
        {
            string consultaSQL = "SELECT Empleado.legajo, " +
                "Empleado.nombre, " +
                "Empleado.apellido, " +
                "Usuario.nombre AS Usuario, " +
                "Usuario.fechaAlta, " +
                "Perfil.nombre AS Perfil " +
                "FROM Empleado " +
                "INNER JOIN Usuario ON Empleado.usuario = Usuario.nombre " +
                "INNER JOIN Perfil ON Usuario.idPerfil = Perfil.idPerfil";

            var dm = new DataManager();
            consultaSQL = AgregarParametrosEmpleado(diccParametros, consultaSQL);
            var busqueda = dm.ConsultaSQLConParametros2(consultaSQL, diccParametros);

            return busqueda;
        }

        private string AgregarParametrosEmpleado(Dictionary<string, object> diccParametros, string consultaSQL)
        {
            if (diccParametros.ContainsKey("nombreEmpleado"))
                consultaSQL += " AND (Empleado.nombre LIKE '%' + @nombreEmpleado + '%') ";

            if (diccParametros.ContainsKey("apellidoEmpleado"))
                consultaSQL += " AND (Empleado.apellido LIKE '%' + @apellidoEmpleado + '%') ";

            if (diccParametros.ContainsKey("usuario"))
                consultaSQL += " AND (Usuario.nombre LIKE '%' + @usuario + '%') ";

            if (diccParametros.ContainsKey("fechaDesde"))
                consultaSQL += " AND (Usuario.fechaAlta BETWEEN @fechaDesde AND @fechaHasta) ";

            return consultaSQL;
        }

        internal DataTable GetVentasPorMes()
        {
            string consultaSql = "SELECT " +
                "COUNT(financiacion) AS VentasFinanciadas, " +
                "(COUNT(idVenta) - COUNT(financiacion) ) AS VentasContado, " +
                "DATENAME( MONTH, DATEADD(MONTH, MONTH(fechaVenta), -1)) AS Mes " +
                "FROM Venta " +
                "GROUP BY MONTH(fechaVenta)";
            
            var dm = new DataManager();
            var busqueda = dm.ConsultaSQL2(consultaSql);

            return busqueda;
        }
      
        internal DataTable GetCuotasByDireccion()
        {
            string consultaSql = "select " +
                "concat (i.calle, ' ', i.calleNro) as DireccionInmueble, " +
                "count(fechaPago) as CuotasPagadas, " +
                "(count(*) - COUNT(fechaPago)) as CuotasPendientes " +
                "from Cuota c " +
                "join Venta v on c.idVenta = v.idVenta " +
                "join Inmueble i on v.idInmueble = i.idInmueble " +
                "group by i.idInmueble, i.calle, i.calleNro";

            var dm = new DataManager();
            var busqueda = dm.ConsultaSQL2(consultaSql);

            return busqueda;
        }

        internal DataTable GetByFiltersRptVenta(Dictionary<string, object> diccParametros)
        {
            string consultaSQL = "SELECT Venta.idVenta, " +
                "Inmueble.calle AS calleInmueble, " +
                "Inmueble.calleNro, " +
                "Cliente.nombre AS nombreCliente, " +
                "Cliente.apellido AS apellidoCliente, " +
                "Venta.legajoVendedor, " +
                "Venta.fechaVenta, " +
                "Venta.fechaEntrega, " +
                "Venta.montoCuota, " +
                "Venta.montoTotal " +
                "FROM Inmueble " +
                "INNER JOIN Venta ON Inmueble.idInmueble = Venta.idInmueble " +
                "INNER JOIN Cliente ON Venta.dniCliente = Cliente.dni";

            var dm = new DataManager();
            consultaSQL = AgregarParametrosVenta(diccParametros, consultaSQL);
            var busqueda = dm.ConsultaSQLConParametros2(consultaSQL, diccParametros);

            return busqueda;
        }
      
        internal DataTable GetByFiltersRptCuota(Dictionary<string, object> diccParametros)
        {
            string consultaSQL = "SELECT Cuota.nroCuota, " +
                "Cuota.fechaVencimiento, " +
                "Cuota.fechaPago, " +
                "Venta.idInmueble, " +
                "Venta.dniCliente, " +
                "Venta.montoCuota, " +
                "Cliente.nombre, " +
                "Cliente.apellido, " +
                "Inmueble.calle " +
                "FROM Cliente " +
                "INNER JOIN Venta ON Cliente.dni = Venta.dniCliente " +
                "INNER JOIN Cuota ON Venta.idVenta = Cuota.idVenta " +
                "INNER JOIN Inmueble ON Venta.idInmueble = Inmueble.idInmueble";

            var dm = new DataManager();
            consultaSQL = AgregarParametrosCuotas(diccParametros, consultaSQL);
            var busqueda = dm.ConsultaSQLConParametros2(consultaSQL, diccParametros);

            return busqueda;
        }

        private string AgregarParametrosCuotas(Dictionary<string, object> diccParametros, string consultaSQL)
        {
            if (diccParametros.ContainsKey("calleInmueble"))
                consultaSQL += " AND (Inmueble.calle LIKE '%' + @calleInmueble + '%') ";

            if (diccParametros.ContainsKey("nombreCliente"))
                consultaSQL += " AND (Cliente.nombre LIKE '%' + @nombreCliente + '%') ";

            if (diccParametros.ContainsKey("apellidoCliente"))
                consultaSQL += " AND (Cliente.apellido LIKE '%' + @apellidoCliente + '%') ";

            if (diccParametros.ContainsKey("fechaDesde"))
                consultaSQL += " AND (Cuota.fechaVencimiento BETWEEN @fechaDesde AND @fechaHasta) ";

            return consultaSQL;
        }

        private string AgregarParametros(Dictionary<string, object> diccParametros, string consultaSQL)
        {
            if (diccParametros.ContainsKey("idInmueble"))
                consultaSQL += " AND (Inmueble.idInmueble =@idInmueble) ";

            if (diccParametros.ContainsKey("fechaDesde"))
                consultaSQL += " AND (HistorialEstado.fechaInicio BETWEEN @fechaDesde AND @fechaHasta) ";

            return consultaSQL;
        }
        private string AgregarParametrosVenta(Dictionary<string, object> diccParametros, string consultaSQL)
        {
            if (diccParametros.ContainsKey("nombreInmueble"))
                consultaSQL += " AND (Inmueble.calle LIKE '%' + @nombreInmueble + '%') ";

            if (diccParametros.ContainsKey("fechaVentaDesde"))
                consultaSQL += " AND (Venta.fechaVenta BETWEEN @fechaVentaDesde AND @fechaVentaHasta) ";

            if (diccParametros.ContainsKey("nombreComprador"))
                consultaSQL += " AND (Cliente.nombre LIKE '%' + @nombreComprador + '%') ";

            if (diccParametros.ContainsKey("apellidoComprador"))
                consultaSQL += " AND (Cliente.apellido LIKE '%' + @apellidoComprador + '%') ";

            return consultaSQL;
        }
    }
}
