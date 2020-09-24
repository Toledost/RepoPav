using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTWF2020.Entities
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime FechaCreada { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string UsuarioCreado { get; set; }
        public string UsuarioActualizacion { get; set; }
        public TipoTransaccion TipoTransaccion { get; set; }
        public Inmueble Inmueble { get; set; }
        public int DniCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public MedioDeConocimiento MedioConocimiento { get; set; }
        public ViaDeConsulta ViaDeConsulta { get; set; }
        public EstadoConsulta EstadoConsulta { get; set; }

    }
}
