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
        private static string connectionString = @"Data Source=DESKTOP-8I3ONNI;Initial Catalog=prueba;Integrated Security=True";

        public static DataTable Consultar(string consultaSQL)
        {
            using (var conn = new SqlConnection())
            
                conn.ConnectionString = "asd";
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
