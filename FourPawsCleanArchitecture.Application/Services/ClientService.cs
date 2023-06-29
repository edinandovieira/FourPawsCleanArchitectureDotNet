using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClienteRepository _repository;

        public ClientService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public Cliente CreateClient(ClientInput cliente)
        {
            var newClient = new Cliente
            {
                Codigo = new Guid(),
                Nome = cliente.nome,
                RG = cliente.rg,
                CPF = cliente.cpf,
                Endereco= cliente.endereco,
                Email = cliente.email,
                Bairro = cliente.bairro,
                Telefone = cliente.telefone,
                Celular = cliente.celular
            };
            var response = _repository.CreateClient(newClient);
            return response;
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
