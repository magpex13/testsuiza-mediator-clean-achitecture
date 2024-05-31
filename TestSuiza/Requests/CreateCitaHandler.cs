using AutoMapper;
using Core;
using MediatR;
using TestSuiza.DTO;
using TestSuiza.Models;

namespace TestSuiza.Requests
{
    public class CreateCitaHandler : IRequestHandler<CreateCita, bool>
    {
        private ICitaService _citaService;

        private IMapper _mapper;

        public CreateCitaHandler(ICitaService citaService, IMapper mapper)
        {
            _citaService = citaService;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateCita request, CancellationToken cancellationToken)
        {
            CitaEntity citaEntity = _mapper.Map<CitaEntity>(request);
            bool isOk = await _citaService.add(citaEntity);
            return isOk;
        }
    }
}
