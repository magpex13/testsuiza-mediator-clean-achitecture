using MediatR;
using System.ComponentModel.DataAnnotations;

namespace TestSuiza.Requests
{
    public class CreateCita: IRequest<bool>
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
    }
}
