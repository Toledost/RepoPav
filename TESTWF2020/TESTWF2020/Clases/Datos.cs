using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace TESTWF2020.Clases
{
    static class Datos
    {
        private static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Federico\Documents\ProyectoBugs.mdb";

        public static DataTable Consultar(string consultaSQL)
        {
            using (var conn = new OleDbConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();                

                using (var command = new OleDbCommand(consultaSQL, conn))
                {
                    DataTable tabla = new DataTable();
                    tabla.Load(command.ExecuteReader());
                    return tabla;
                }

            }
        }
    }
}
