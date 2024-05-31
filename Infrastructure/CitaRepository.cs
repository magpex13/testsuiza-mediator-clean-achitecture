using AutoMapper;
using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class CitaRepository : ICitaRepository
    {
        private IMapper _mapper;
        public CitaRepository(IMapper mapper) {
            _mapper = mapper;
        }

        public async Task<bool> Add(CitaEntity citaEntity)
        {
            var cita = _mapper.Map<Cita>(citaEntity);
            using (var context = new Context())
            {
                context.Add(cita);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CitaEntity>> GetCitaEntities(string numeroDocumento = "")
        {
            using (var context = new Context())
            {
                List<Cita> citas = null;
                if (string.IsNullOrEmpty(numeroDocumento))
                {
                    citas = await context.Citas.ToListAsync();
                }
                else
                {
                    citas = await context.Citas.Where(x => x.NumeroDocumento == numeroDocumento).ToListAsync();
                }

                return _mapper.Map<List<CitaEntity>>(citas);
            }
        }

        public async Task<bool> Update(CitaEntity citaEntity)
        {
            var cita = _mapper.Map<Cita>(citaEntity);
            using (var context = new Context())
            {
                context.Add(cita);
                await context.SaveChangesAsync();
                return true;
            }
        }
    }
}
