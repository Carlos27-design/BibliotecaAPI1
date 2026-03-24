using System.ComponentModel.DataAnnotations;

namespace BibliotecaAPI.DTOs
{
    public class LibroCreateDTO
    {
        [Required]
        public required string Titulo { get; set; }
        public int AutorId { get; set; }
    }
}
