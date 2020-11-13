﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TESTWF2020.DataAccessLayer
{
    public class DataManager
    {
        public SqlConnection dbConnection;
        private SqlTransaction dbTransaction;

        private static DataManager instance = new DataManager();
        public DataManager()
        {
            dbConnection = new SqlConnection();
            // var dataBaseName = ConfigurationManager.AppSettings["dataBaseName"];
            // var string_conexion = ConfigurationManager.ConnectionStrings[dataBaseName].ConnectionString;
            //dbConnection.ConnectionString = @"Data Source=186.13.121.219;Initial Catalog=BDInmobiliariaCasaFeliz;Persist Security Info=True;User ID=usertest;Password=pepito";
            //dbConnection.ConnectionString = @"Data Source=DESKTOP-60MCHVF;Initial Catalog=BDInmobiliariaCasaFeliz;Integrated Security=True";
            dbConnection.ConnectionString = @"Data Source=DESKTOP-8I3ONNI;Initial Catalog=BDInmobiliariaCasaFeliz;Integrated Security=True";
            //dbConnection.ConnectionString = @"Data Source=DESKTOP-0C4GOB8\SQLEXPRESS;Initial Catalog=BDInmobiliariaCasaFeliz;Integrated Security=True";
            //dbConnection.ConnectionString = @"Data Source=DESKTOP-VA1EDAU\SQLEXPRESS;Initial Catalog=BDInmobiliariaCasaFeliz;Integrated Security=True";
        }

        public void BeginTransaction()
        {

            if (dbConnection.State == ConnectionState.Open)
                dbTransaction = dbConnection.BeginTransaction();
        }

        public static DataManager GetInstance()
        {
            if (instance == null)
                instance = new DataManager();

            //instance.Open();

            return instance;
        }

        public void Commit()
        {
            if (dbTransaction != null)
                dbTransaction.Commit();
        }

        public void Rollback()
        {
            if (dbTransaction != null)
                dbTransaction.Rollback();
        }

        internal void EjecutarSQLConParametros2(string consultaSQL, Dictionary<object, string> parametros)
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            if (dbConnection.State != ConnectionState.Open)
                dbConnection.Open();
        }

        public void Close()
        {
            if (dbConnection.State != ConnectionState.Closed)
                dbConnection.Close();
        }


        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public DataTable ConsultaSQL(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }

        public DataTable ConsultaSQL2(string consulta)
        {
            using (var conn = dbConnection)
            {
                try
                {
                    conn.Open();

                    using (var command = new SqlCommand(consulta, conn))
                    {
                        DataTable tabla = new DataTable();
                        tabla.Load(command.ExecuteReader());
                        return tabla;
                    }
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
        }

        /// Resumen:
        ///      Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        ///      La función recibe por valor una sentencia sql como string y un diccionario de objetos como parámetros
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public DataTable ConsultaSQLConParametros(string strSql, Dictionary<string, object> prs)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                foreach (var item in prs)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public DataTable ConsultaSQLConParametros2(string consulta, Dictionary<string, object> parametros)
        {
            using (var conn = dbConnection)
            {
                try
                {
                    conn.Open();

                    using (var command = new SqlCommand(consulta, conn))
                    {
                        foreach (var item in parametros)
                        {
                            command.Parameters.AddWithValue(item.Key, item.Value);
                        }
                        DataTable tabla = new DataTable();
                        tabla.Load(command.ExecuteReader());
                        return tabla;
                    }   

                }
                catch (Exception ex)
                {

                    throw (ex);
                }
            }
        }

        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public int EjecutarSQLConParametros(string strSql, Dictionary<string, object> parametros = null)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                cmd.Connection = dbConnection;
                cmd.Transaction = dbTransaction;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                foreach (var item in parametros)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }


                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }

        public int EjecutarSQLConParametros2(string consulta, Dictionary<string, object> parametros = null)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

            int resultado = 0;

            using (var conn = dbConnection)
            {
                try
                {
                    conn.Open();
                    BeginTransaction();

                    using (var command = new SqlCommand(consulta, conn))
                    {
                        command.Transaction = dbTransaction;
                        foreach (var item in parametros)
                        {
                            command.Parameters.AddWithValue(item.Key, item.Value);
                        }

                        resultado = command.ExecuteNonQuery();
                    }
                    Commit();
                }
                catch (Exception ex)
                {
                    Rollback();
                    throw (ex);
                }
            }
            return resultado;
        }

        public int EjecutarSQL(string strSql)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                cmd.Connection = dbConnection;
                cmd.Transaction = dbTransaction;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }


        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public object ConsultaSQLScalar(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = dbConnection;
                cmd.Transaction = dbTransaction;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }

    }
}
