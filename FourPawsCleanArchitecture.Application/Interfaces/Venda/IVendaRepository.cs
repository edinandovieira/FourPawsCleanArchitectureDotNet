using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IVendaRepository
    {
        List<VendaList> GetAllSale();
        List<Venda> GetSale(Guid codigo);
        List<Venda> CreateSale(List<Venda> venda, List<Produto> produto);
        Venda UpdateSale(Venda venda);
        Venda RemoveSale(Venda venda);
    }
}
