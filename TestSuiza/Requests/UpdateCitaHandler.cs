using AutoMapper;
using Core;
using MediatR;
using TestSuiza.DTO;
using TestSuiza.Models;

namespace TestSuiza.Requests
{
    public class UpdateCitaHandler : IRequestHandler<UpdateCita,bool>
    {
        private ICitaService _citaService;

        private IMapper _mapper;

        public UpdateCitaHandler(ICitaService citaService, IMapper mapper)
        {
            _citaService = citaService;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateCita request, CancellationToken cancellationToken)
        {
            CitaEntity citaEntity = _mapper.Map<CitaEntity>(request);
            bool isOk = await _citaService.update(citaEntity);
            return isOk;
        }
    }
}
