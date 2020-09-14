﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    public class HistorialEstadoDao
    {
        public IList<HistorialEstado> GetHistorialEstadoByInmuebleID(int idInmueble)
        {
            IList<HistorialEstado> historial = new List<HistorialEstado>();
            var dm = new DataManager();

            string consultaSQL = "SELECT " +
                "h.idInmueble, " +
                "h.fechaInicio, " +
                "h.fechaFin, " +
                "e.nombre AS nombreEstado, " +
                "e.idEstadoInmueble " +
                "FROM HistorialEstado h " +
                "JOIN EstadoInmueble e ON h.idEstadoInmueble = e.idEstadoInmueble " +
                $"WHERE h.idInmueble = {idInmueble} AND h.borrado = 0";

            var busqueda = dm.ConsultaSQL2(consultaSQL);

            if (busqueda.Rows.Count > 0)
            {
                 foreach(DataRow row in busqueda.Rows)
                {
                    historial.Add(MapToEntity(row));
                }
            }
            return historial;
        }

        internal IList<HistorialEstado> GetAll()
        {
            IList<HistorialEstado> historial = new List<HistorialEstado>();
            var dm = new DataManager();

            string consultaSQL = "SELECT " +
                "h.idInmueble, " +
                "e.nombre AS nombreEstado, " +
                "e.idEstadoInmueble " +
                "FROM HistorialEstado h " +
                "JOIN EstadoInmueble e ON h.idEstadoInmueble = e.idEstadoInmueble " +
                "WHERE h.borrado = 0";
                
            var busqueda = dm.ConsultaSQL2(consultaSQL);

            if (busqueda.Rows.Count > 0)
            {
                foreach (DataRow row in busqueda.Rows)
                {
                    historial.Add(MapToEntity(row));
                }
            }
            return historial;
        }

        public HistorialEstado MapToEntity(DataRow dataRow)
        {
            HistorialEstado historialEstado = new HistorialEstado
            {
                Estado = new EstadoInmueble
                {
                    Id = (int)dataRow["idEstadoInmueble"],
                    Nombre = dataRow["nombreEstado"].ToString()
                },
                FechaFin = dataRow["fechaFin"] != DBNull.Value ? (DateTime)dataRow["fechaFin"] : new DateTime(),
                FechaInicio = (DateTime)dataRow["fechaInicio"],
            };
            return historialEstado;
        }
    }
}
