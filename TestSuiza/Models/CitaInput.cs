using System.ComponentModel.DataAnnotations;

namespace TestSuiza.Models
{
    public class CitaInput
    {
        public int id { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
    }
}
