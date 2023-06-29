using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IClientService
    {
        List<Cliente> GetAllClient();
        Cliente GetClient(Guid codigo);
        Cliente CreateClient(ClientInput cliente);
        Cliente UpdateClient(Cliente cliente);
        Cliente RemoveClient(Cliente cliente);
    }
}
