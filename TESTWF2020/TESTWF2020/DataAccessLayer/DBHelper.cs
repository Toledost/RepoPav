using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.DataAccessLayer
{
    public class DBHelper
    {
        private static DBHelper instance = new DBHelper();
        private string connectionString = @"Data Source=186.13.121.219;Initial Catalog=BDInmobiliariaCasaFeliz;Persist Security Info=True;User ID=usertest;Password=pepito";
        //private string connectionString = @"Data Source=DESKTOP-60MCHVF;Initial Catalog=BDInmobiliariaCasaFeliz;Integrated Security=True";

        public static DBHelper GetDBHelper()
        {
            if (instance == null)
            {
                instance = new DBHelper();
            }
            return instance;
        }

        public DataTable ConsultaSql(string consulta) 
        {
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();

                using (var command = new SqlCommand(consulta, conn))
                {
                    DataTable tabla = new DataTable();
                    tabla.Load(command.ExecuteReader());
                    return tabla;
                }
            }
        }
    }
}
