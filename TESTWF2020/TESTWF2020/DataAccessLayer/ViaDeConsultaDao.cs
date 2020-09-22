using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TESTWF2020.Entities;

namespace TESTWF2020.DataAccessLayer
{
    public class ViaDeConsultaDao
    {
        internal IList<ViaDeConsulta> GetAll()
        {
            IList<ViaDeConsulta> listaViaDeConsultas = new List<ViaDeConsulta>();
            DataManager dm = new DataManager();

            string consultaSQL = "SELECT idViaDeConsulta, " +
                " nombre, " +
                " descripcion " +
                " FROM ViaDeConsulta" +
                " WHERE borrado = 0";

            var resultado = dm.ConsultaSQL2(consultaSQL);
            if (resultado.Rows.Count >0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    listaViaDeConsultas.Add(MapToEntity(row));
                }
            }
            return listaViaDeConsultas;
        }

        internal void Create(ViaDeConsulta viaDeConsulta)
        {
            string consultaSQL = "INSERT INTO ViaDeConsulta " +
                "([nombre] " +
                //",[idViaDeConsulta] " +
                ",[descripcion]) " +
                "VALUES " +
                "(@nombre " +
                //",@idViaDeConsulta " +
                ",@descripcion) ";

            var parametros = new Dictionary<string, object>();

            parametros.Add("nombre", viaDeConsulta.Nombre);
            parametros.Add("idViaDeConsulta", viaDeConsulta.Id);
            parametros.Add("descripcion", viaDeConsulta.Descripcion);

            DataManager dm = new DataManager();
            var resultado = dm.ConsultaSQLConParametros2(consultaSQL, parametros);
        }

        internal ViaDeConsulta GetById(int idViaConsulta)
        {
            ViaDeConsulta resultado = null;
            DataManager dm = new DataManager();

            string consultaSQL = "SELECT idViaDeConsulta, " +
                " nombre, " +
                " descripcion " +
                " FROM ViaDeConsulta" +
                " WHERE borrado = 0 " +
                $" AND idViaDeConsulta= { idViaConsulta }";

            var busqueda = dm.ConsultaSQL2(consultaSQL);
            if (busqueda.Rows.Count >0)
            {
                resultado = MapToEntity(busqueda.Rows[0]);
            }
            return resultado;
        }

        private ViaDeConsulta MapToEntity(DataRow row)
        {
            ViaDeConsulta viaDeConsulta = new ViaDeConsulta
            {
                Id = (int)row["idViaDeConsulta"],
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString()
            };
            return viaDeConsulta;
            
        }
    }
}
