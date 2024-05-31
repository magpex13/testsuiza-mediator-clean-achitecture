namespace Core
{
    public class CitaService :  ICitaService
    {
        private ICitaRepository _repository;

        public CitaService(ICitaRepository repository) {

            _repository = repository;
        }

        public Task<bool> add(CitaEntity citaEntity)
        {
            return _repository.Add(citaEntity);
        }

        public Task<bool> delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CitaEntity>> list(string numeroDocumento)
        {
            return _repository.GetCitaEntities();
        }

        public Task<bool> update(CitaEntity citaEntity)
        {
            return _repository.Update(citaEntity);
        }
    }
}