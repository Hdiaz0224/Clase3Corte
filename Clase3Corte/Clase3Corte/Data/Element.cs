using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Clase3Corte.Data
{
    public class Libro
    {
        [Key]
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }
        public int Pagina { get; set; }
        public string Descripcion { get; set; }
    }
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }
        public string Descripcion { get; set; }

    }
}
