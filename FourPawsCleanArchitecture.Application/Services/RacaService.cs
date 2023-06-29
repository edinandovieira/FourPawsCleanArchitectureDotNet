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

        public Raca CreateRaca(string nome, string fileName, FileStream file)
        {
            var Raca = new Raca
            {
                Codigo = new Guid(),
                Nome = nome,
                Avatar = "Assets/Breed/" + fileName
            };
            var response = _repository.CreateRaca(Raca, file);
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

        public Raca RemoveRaca(Guid codigo)
        {
            var Raca = _repository.GetRaca(codigo);

            _repository.RemoveRaca(Raca);
            return Raca;
        }

        public Raca UpdateRaca(Guid codigo, string nome, string status, string? filename = null, FileStream? file = null)
        {
            var Raca = _repository.GetRaca(codigo);

            string path = $@"../FourPawsCleanArchitecture.Infraestructure/{Raca.Avatar}";

            Raca.Nome = nome;
            Raca.Status = status;

            if(!string.IsNullOrEmpty(filename))
            {
                Raca.Avatar = $"Assets/Breed/{filename}";
                var response = _repository.UpdateRaca(Raca, file);
                System.IO.File.Delete(path);
                return response;
            }
            else
            {
                var response = _repository.UpdateRaca(Raca, file);
                return response;

            }
        }
    }
}
