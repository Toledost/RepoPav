using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;
using System.Data;
using System.Runtime.InteropServices.ComTypes;

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

        internal void Update(Cliente cliente)
        {
            string consultaSql = "UPDATE Cliente " +
                "SET " +
                "[nombre] = @nombre" +
                ",[apellido] = @apellido" +
                ",[mail] = @mail" +
                ",[telefono] = @telefono " + 
                "WHERE dni = @dni";

            var parametros = new Dictionary<string, object>();

            parametros.Add("dni", cliente.Dni);
            parametros.Add("nombre", cliente.Nombre);
            parametros.Add("apellido", cliente.Apellido);
            parametros.Add("mail", cliente.Mail);
            parametros.Add("telefono", cliente.Telefono);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        internal void Recuperar(Cliente cliente)
        {
            var parametros = new Dictionary<string, object>();

            string consultaSql = "UPDATE Cliente " +
                "SET borrado = 0 " +
                "WHERE dni = @dni ";

            parametros.Add("dni", cliente.Dni);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        internal void Delete(int clienteSeleccionado)
        {
            var parametros = new Dictionary<string, object>();

            string consultaSql = "UPDATE Cliente " +
                "SET borrado = 1 " +
                "WHERE dni = @dni ";


            parametros.Add("dni", clienteSeleccionado);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        internal void Create(Cliente cliente)
        {
            string consultaSql = "INSERT INTO Cliente " +
                "([dni]" +
                ",[nombre]" +
                ",[apellido]" +
                ",[mail]" +
                ",[telefono]) " +
                "VALUES " +
                "(@dni" +
                ",@nombre" +
                ",@apellido" +
                ",@mail" +
                ",@telefono) ";

            var parametros = new Dictionary<string, object>();

            parametros.Add("dni", cliente.Dni);
            parametros.Add("nombre", cliente.Nombre);
            parametros.Add("apellido", cliente.Apellido);
            parametros.Add("mail", cliente.Mail);
            parametros.Add("telefono", cliente.Telefono);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        internal Cliente GetByDni(int dniClienteSeleccionado, bool buscarBorrados = false)
        {
            Cliente resultado = null;
            var dm = new DataManager();

            string consultaSQL = "SELECT " +
                 "dni, " +
                 "nombre, " +
                 "apellido, " +
                 "mail, " +
                 "telefono " +
                 "FROM  Cliente " +
                 $"WHERE borrado = {(buscarBorrados ? 1 : 0)} " +
            $"AND dni = {dniClienteSeleccionado}";            

            var busqueda = dm.ConsultaSQL2(consultaSQL);
            if (busqueda.Rows.Count > 0)
            {
                resultado = MapToEntity(busqueda.Rows[0]);
            }
            return resultado;
        }

        internal IList<Cliente> GetByFilters(Dictionary<string, object> dicc)
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
                "WHERE borrado = 0 ";

            consultaSQL = AgregarParametros(dicc, consultaSQL);

            var busqueda = dm.ConsultaSQLConParametros2(consultaSQL,dicc);

            if (busqueda.Rows.Count > 0)
            {
                foreach (DataRow row in busqueda.Rows)
                {
                    listaClientes.Add(MapToEntity(row));
                }
            }
            return listaClientes;
        }

        private string AgregarParametros(Dictionary<string, object> dicc, string consultaSql)
        {
            if (dicc.ContainsKey("dni"))
                consultaSql += " AND (dni =@dni) ";

            if (dicc.ContainsKey("nombre"))
                consultaSql += " AND (nombre LIKE '%' + @nombre + '%') ";

            if (dicc.ContainsKey("apellido"))
                consultaSql += " AND (apellido LIKE '%' + @apellido + '%') ";

            return consultaSql;
        }

            private Cliente MapToEntity(DataRow row)
        {
            Cliente cliente = new Cliente
            {
                Dni = (int)row["dni"],
                Nombre = row["nombre"].ToString(),
                Apellido = row["apellido"].ToString(),
                Mail = row["mail"].ToString(),
                Telefono = (long)row["telefono"]

            };
            return cliente;
        }



    }
}
