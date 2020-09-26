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
        public Usuario UsuarioUltimaModificacion { get; set; }
        public TipoTransaccion TipoTransaccion { get; set; }
        public Inmueble Inmueble { get; set; }
        public Cliente Cliente { get; set; }
        public MedioDeConocimiento MedioConocimiento { get; set; }
        public ViaDeConsulta ViaDeConsulta { get; set; }
        public EstadoConsulta EstadoConsulta { get; set; }

    }
}
