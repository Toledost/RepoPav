namespace TESTWF2020.Entities
{
    public class EstadoConsulta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}