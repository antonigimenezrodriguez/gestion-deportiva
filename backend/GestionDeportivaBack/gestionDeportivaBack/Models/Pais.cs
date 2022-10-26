namespace gestionDeportivaBack.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Provincia> Provincias { get; set; }
    }
}
