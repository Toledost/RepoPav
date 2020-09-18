using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;
using System.Data;

namespace TESTWF2020.DataAccessLayer
{
    class ClienteDao
    {

        internal IList<Cliente> GetAll()
        {
            
            IList<Cliente> listaClientes = new List<Cliente>();

            var dm = new DataManager();

            string consultaSQL = "SELECT " +
                 "dni, " +
                 "nombre, " +
                 "apellido, " +
                 "mail, " +
                 "telefono " +
                 "FROM  Cliente " +
                 "WHERE borrado = 0";

            var busqueda = dm.ConsultaSQL2(consultaSQL);

            if (busqueda.Rows.Count > 0)
            {
                foreach (DataRow row in busqueda.Rows)
                {
                    listaClientes.Add(MapToEntity(row));
                }
            }
            return listaClientes;                      
                       
        }

        private Cliente MapToEntity(DataRow row)
        {
            Cliente cliente = new Cliente
            {
                Dni = (int)row["dni"],
                Nombre = row["nombre"].ToString(),
                Apellido = row["apellido"].ToString(),
                Mail = row["mail"].ToString(),
                Telefono = (int)row["telefono"]

            };
            return cliente;
        }
    }
}
