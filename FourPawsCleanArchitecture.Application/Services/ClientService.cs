using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClienteRepository _repository;

        public ClientService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public Cliente CreateClient(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAllClient()
        {
            var response = _repository.GetAllClient();
            return response;
        }

        public Cliente GetClient(Guid codigo)
        {
            var response = _repository.GetClient(codigo);
            return response;
        }

        public Cliente RemoveClient(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente UpdateClient(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
