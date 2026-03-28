using System.ComponentModel.DataAnnotations;

namespace BibliotecaAPI
{
    public class TarifaOpciones
    {
        public const string Seccion = "tarifas";

        [Required]
        public required int Dia { get; set; }

        [Required]
        public required int Noche { get; set; }
    }
}
