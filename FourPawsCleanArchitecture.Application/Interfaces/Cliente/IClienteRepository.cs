using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IClienteRepository
    {
        List<Cliente> GetAllClient();
        Cliente GetClient(Guid codigo);
        Cliente CreateClient(Cliente cliente);
        Cliente UpdateClient(Cliente cliente);
        Cliente RemoveClient(Cliente cliente);
    }
}
