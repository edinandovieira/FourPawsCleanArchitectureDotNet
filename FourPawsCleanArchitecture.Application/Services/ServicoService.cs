using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class ServicoService : IServicoService
    {
        private readonly IServicoRepository _repository;

        public ServicoService(IServicoRepository repository)
        {
            _repository = repository;
        }

        public Servico CreateServico(RServicoPrincipal rServicoPrincipal)
        {
            var service = new Servico
            {
                Codigo = new Guid(),
                Nome = rServicoPrincipal.Nome,
                Status = rServicoPrincipal.Status
            };

            _repository.CreateServico(service);
            return service;
        }

        public List<Servico> GetAllServico()
        {
            return _repository.GetAllServico();
        }

        public Servico GetServico(Guid codigo)
        {
            return _repository.GetServico(codigo);
        }

        public Servico RemoveServico(Servico servico)
        {
            _repository.RemoveServico(servico);
            return servico;
        }

        public Servico UpdateServico(Servico servico)
        {
            _repository.UpdateServico(servico);
            return servico;
        }
    }
}
