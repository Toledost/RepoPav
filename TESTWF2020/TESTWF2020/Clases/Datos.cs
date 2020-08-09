using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TESTWF2020.Clases
{
    static class Datos
    {
        private static string connectionString = "";
        public static DataTable Consultar(string consultaSQL)
        {
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();                

                using (var command = new SqlCommand(consultaSQL, conn))
                {
                    DataTable tabla = new DataTable();
                    tabla.Load(command.ExecuteReader());
                    return tabla;
                }

            }
        }
    }
}
