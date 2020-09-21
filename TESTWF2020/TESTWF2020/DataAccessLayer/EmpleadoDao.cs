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

        public IList<Empleado> GetEmpleados()
        {
            var empleados = new List<Empleado>();
            DataManager dm = new DataManager();

            string consultaSQL = "SELECT e.legajo, e.nombre, e.apellido, u.nombre AS usuario " +
                                 "FROM Empleado e " +
                                 "JOIN Usuario u ON e.usuario = u.nombre " +
                                 "WHERE e.borrado = 0";

            var busqueda = dm.ConsultaSQL2(consultaSQL);

            foreach (DataRow row in busqueda.Rows)
            {
                empleados.Add(MapToEntity(row));
            }
            return empleados;

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

        #endregion
    }
}
