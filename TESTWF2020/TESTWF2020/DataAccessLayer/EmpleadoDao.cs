using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    class EmpleadoDao
    {
        #region Metodos Publicos

        public IList<Empleado> GetByFilters(Dictionary<string, object> parametros)
        {
            var empleados = new List<Empleado>();
            DataManager dm = new DataManager();

            string consultaSQL = "SELECT e.legajo, e.nombre, e.apellido, u.nombre AS usuario " +
                                 "FROM Empleado e " +
                                 "JOIN Usuario u ON e.usuario = u.nombre " +
                                 "WHERE e.borrado = 0";

            consultaSQL = AgregarParametros(parametros, consultaSQL);

            var busqueda = dm.ConsultaSQLConParametros2(consultaSQL, parametros);
            foreach (DataRow row in busqueda.Rows)
            {
                empleados.Add(MapToEntity(row));
            }

            return empleados;
        }

        public Empleado GetByLegajo(int legajo)
        {
            Empleado empleado = null;
            DataManager dm = new DataManager();

            string consultaSQL = "SELECT legajo, nombre, apellido, usuario " +
                                 "FROM Empleado " +
                                 "WHERE borrado = 0 " +
                                 $"AND legajo = {legajo}";

            var busqueda = dm.ConsultaSQL2(consultaSQL);

            if (busqueda.Rows.Count > 0)
            {
                empleado = MapToEntity(busqueda.Rows[0]);
            }

            return empleado;
        }

        public void Delete(int legajo)
        {
            var parametros = new Dictionary<string, object>();

            string consultaSql = "UPDATE Empleado SET borrado = 1 WHERE legajo = @legajo";

            parametros.Add("legajo", legajo);

            DataManager dm = new DataManager();
            var resultado = dm.EjecutarSQLConParametros2(consultaSql, parametros);
        }

        public void Create(Empleado empleado)
        {
            string consultaSQL = "INSERT INTO Empleado " +
                                 "([legajo], " +
                                 "[nombre], " +
                                 "[apellido], " +
                                 "[usuario]) " +
                                 "VALUES " +
                                 "(@legajo," +
                                 "@nombre," +
                                 "@apellido, " +
                                 "@usuario)";

            var parametros = new Dictionary<string, object>();

            parametros.Add("legajo", empleado.Legajo);
            parametros.Add("nombre", empleado.Nombre);
            parametros.Add("apellido", empleado.Apellido);
            parametros.Add("usuario", empleado.Usuario.Nombre);

            DataManager dm = new DataManager();
            dm.EjecutarSQLConParametros2(consultaSQL, parametros);
        }

        public void Update(Empleado empleado, int legajo)
        {
            DataManager dm = new DataManager();
            
            string consultaSQL = "UPDATE Empleado " +
                                 "SET " +
                                 "[legajo] = @legajo, " +
                                 "[nombre] = @nombre, " +
                                 "[apellido] = @apellido, " +
                                 "[usuario] = @usuario " +
                                 $"WHERE legajo = {legajo}";

            var parametros = new Dictionary<string, object>();

            parametros.Add("legajo", empleado.Legajo);
            parametros.Add("nombre", empleado.Nombre);
            parametros.Add("apellido", empleado.Apellido);
            parametros.Add("usuario", empleado.Usuario.Nombre);

            dm.EjecutarSQLConParametros2(consultaSQL, parametros);
        }

        #endregion

        #region Metodos Privados
        private Empleado MapToEntity(DataRow row)
        {
            Empleado empleado = new Empleado
            {
                Legajo = (int)row["legajo"],
                Nombre = row["nombre"].ToString(),
                Apellido = row["apellido"].ToString(),
                Usuario = new Usuario
                {
                    Nombre = row["usuario"].ToString()
                }
            };

            return empleado;
        }

        private string AgregarParametros(Dictionary<string, object> parametros, string consultaSql)
        {
            if (parametros.ContainsKey("nombre"))
                consultaSql += "AND (e.nombre LIKE '%' + @nombre + '%') ";

            if (parametros.ContainsKey("apellido"))
                consultaSql += "AND (e.apellido LIKE '%' + @apellido + '%') ";

            if (parametros.ContainsKey("usuario"))
                consultaSql += "AND (u.nombre LIKE '%' + @usuario + '%') ";

            return consultaSql;
        }

        #endregion
    }
}
