using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IVendaService
    {
        List<VendaList> GetAllSale();
        List<Venda> GetSale(Guid codigo);
        List<Venda> CreateSale(List<VendaInput> venda);
        /*Venda UpdateSale(Guid codigo, VendaInput venda, string status);*/
        Venda RemoveSale(Guid codigo);
    }
}
