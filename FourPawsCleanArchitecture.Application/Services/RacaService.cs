using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class RacaService : IRacaService
    {
        private readonly IRacaRepository _repository;

        public RacaService(IRacaRepository repository)
        {
            _repository = repository;
        }

        public Raca CreateRaca(RRacaRequest rRacaRequest)
        {
            var Raca = new Raca
            {
                Codigo = new Guid(),
                Nome = rRacaRequest.Nome,
                Status = rRacaRequest.Status
            };
            var response = _repository.CreateRaca(Raca);
            return response;
        }

        public List<Raca> GetAllRacas()
        {
            return _repository.GetAllRacas();
        }

        public Raca GetRaca(Guid codigo)
        {
            return _repository.GetRaca(codigo);
        }

        public Raca RemoveRaca(Raca raca)
        {
            throw new NotImplementedException();
        }

        public Raca UpdateRaca(Guid codigo, RRacaRequest rRacaRequest)
        {
            var Raca = _repository.GetRaca(codigo);

            Raca.Nome = rRacaRequest.Nome;
            Raca.Status = rRacaRequest.Status;

            var response = _repository.UpdateRaca(Raca);
            return response;
        }
    }
}
