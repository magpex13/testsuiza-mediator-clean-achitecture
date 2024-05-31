using AutoMapper;
using Core;
using MediatR;
using TestSuiza.DTO;
using TestSuiza.Models;

namespace TestSuiza.Requests
{
    public class GetCitasHandler : IRequestHandler<GetCitas, List<CitaListItem>>
    {
        private ICitaService _citaService;

        private IMapper _mapper;

        public GetCitasHandler(ICitaService citaService, IMapper mapper) {
            _citaService = citaService;
            _mapper = mapper;
        }

        public async Task<List<CitaListItem>> Handle(GetCitas request, CancellationToken cancellationToken)
        {
            var citaEntities = _citaService.list(request.NumeroDocumento);
            var lista = _mapper.Map<List<CitaListItem>>(citaEntities);

            return lista;
        }
    }
}
