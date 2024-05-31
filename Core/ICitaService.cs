using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface ICitaService
    { 
        Task<List<CitaEntity>> list(string numeroDocumento = "");
        Task<bool> add(CitaEntity citaEntity);
        Task<bool> update(CitaEntity citaEntity);
        Task<bool> delete(int id);
    }
}
