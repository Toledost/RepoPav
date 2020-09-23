﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;
using System.Data;

namespace TESTWF2020.DataAccessLayer
{
    public class ConsultaDao
    {
        internal  IList<Consulta> GetAll()
        {
            var listaConsulta = new List<Consulta>();

            string consultaSql = "SELECT " +
                "c.idConsulta, " +
                "c.fechaCreada, " +
                "c.usuarioCreado, " +
                "t.idTipoTransaccion, " +
                "i.idInmueble, " +
                //"cl.dni, " +
                //"cl.nombre, " +
                //"cl.apellido, " +
                "m.idMedioConocimiento, " +
                "v.idViaDeConsulta, " +
                "e.idEstadoConsulta, " +
                "c.fechaCierre, " +
                "c.usuarioActualizacion " +
                "FROM Consulta c " +
                //"INNER JOIN Usuario u on c.usuarioCreado = u.nombre " +
                "INNER JOIN TipoTransaccion t on c.idTipoTransaccion = t.idTipoTransaccion " +
                "INNER JOIN Inmueble i on c.idInmueble = i.idInmueble " +
                //"INNER JOIN Cliente cl on c.dniCliente = cl.dni " +
                "INNER JOIN MedioConocimiento m on c.idMedioConocimiento = m.idMedioConocimiento " +
                "INNER JOIN ViaDeConsulta v on c.idViaDeConsulta = v.idViaDeConsulta " +
                "INNER JOIN EstadoConsulta e on e.idEstadoConsulta = e.idEstadoConsulta " +
                "WHERE c.borrado = 0 ";

            DataManager dm = new DataManager();

            var resultado = dm.ConsultaSQL2(consultaSql);

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    listaConsulta.Add(MapToEntity(row));
                }               
            }

            return listaConsulta;
        }

        private Consulta MapToEntity(DataRow row)
        {
            Consulta consulta = new Consulta
            {
                Id = (int)row["idConsulta"],
                FechaCreada = (DateTime)row["fechaCreada"],
                UsuarioCreado = row["usuarioCreado"].ToString(),
                TipoTransaccion = new TipoTransaccion
                {
                    Id = (int)row["idTipoTransaccion"],
                    //Nombre = row["nombre"].ToString(),
                    //Descripcion = row["descripcion"].ToString()
                },
                Inmueble = new Inmueble
                {
                    Id = (int)row["idInmueble"],
                    //Calle = row["calle"].ToString(),
                    //CalleNumero = (int)row["calleNro"],
                    //MetrosCuadrados = (double)row["m2"],
                    //Baños = (int)row["cantBaños"],
                    //Habitaciones = (int)row["cantHabitaciones"],
                    //Descripcion = row["descripcion"].ToString(),
                    //MontoAlquiler = (int)row["montoalquiler"],
                    //MontoVenta = (int)row["montoventa"],
                    //TipoInmueble = new TipoInmueble()
                    //{
                    //    Id = (int)row["idTipoInmueble"],
                    //    //Nombre = row["nombre"].ToString(),
                    //    //Descripcion = row["descripcionTipoInmueble"].ToString()
                    //}
                },

                //DniCliente = (int)row["dniCliente"],
                //NombreCliente = row["nombreCliente"].ToString(),
                //ApellidoCliente = row["apellidoCliente"].ToString(),

                MedioConocimiento = new MedioDeConocimiento
                {
                    Id = (int)row["idMedioConocimiento"],
                    //Nombre = row["nombre"].ToString(),
                    //Descripcion = row["descripcion"].ToString()
                },
                ViaDeConsulta = new ViaDeConsulta
                {
                    Id = (int)row["idViaDeConsulta"],
                    //Nombre = row["nombre"].ToString(),
                    //Descripcion = row["descripcion"].ToString()
                },
                EstadoConsulta = new EstadoConsulta
                {
                    Id = (int)row["idEstadoConsulta"],
                    //Nombre = row["nombre"].ToString(),
                    //Descripcion = row["descripcion"].ToString()
                },
                FechaCierre = row["fechaCierre"] != DBNull.Value ? (DateTime)row["fechaCierre"] : default,
                UsuarioActualizacion = row["usuarioActualizacion"].ToString()
            };

            return consulta;
        }
    }
}
