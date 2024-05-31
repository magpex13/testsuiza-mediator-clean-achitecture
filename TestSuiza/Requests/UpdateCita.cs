using MediatR;

namespace TestSuiza.Requests
{
    public class UpdateCita: IRequest<bool>
    {
        public int Id { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
    }
}
