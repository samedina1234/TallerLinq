namespace TallerLinq.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? ISBN { get; set; }
        public int AutorId { get; set; }

        public Autor? Autor { get; set; }
    }

    public class Autor
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
    }
}
