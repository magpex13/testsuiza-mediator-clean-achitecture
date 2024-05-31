using System.ComponentModel.DataAnnotations;

namespace TestSuiza.Models
{
    public class CitaListItem
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
    }
}
