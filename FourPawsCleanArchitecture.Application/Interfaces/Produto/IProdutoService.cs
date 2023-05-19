using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IProdutoService
    {
        public Produto CreateProduto(RProdutoRequest rProdutoRequest);
        public Produto GetProduto(Guid codigo);
        public List<Produto> GetAllProdutos();
        public Produto UpdateProduto(Guid codigo, RProdutoRequest rProdutoRequest);
        public Produto RemoveProduto(Guid codigo);
    }
}
