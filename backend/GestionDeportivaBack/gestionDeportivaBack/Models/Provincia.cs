namespace gestionDeportivaBack.Models
{
    public class Provincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Pais Pais { get; set; }

        public int PaisId { get; set; }
        public virtual ICollection<Localidad>? Localidades { get; set; }
    }
}
