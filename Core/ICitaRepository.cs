using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface ICitaRepository
    {
        Task<List<CitaEntity>> GetCitaEntities(string numeroDocumento = "");
        Task<bool> Add(CitaEntity citaEntity);
        Task<bool> Update(CitaEntity citaEntity);
        Task<bool> Delete(int id);
    }
}
