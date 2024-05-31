using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TestSuiza.Models
{
    public class CitaInput
    {
        public int id { get; set; }

        [NotNull]
        public string TipoDocumento { get; set; }

        [NotNull]
        public string NumeroDocumento { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
    }
}
