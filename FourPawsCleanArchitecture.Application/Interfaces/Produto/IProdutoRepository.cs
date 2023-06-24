using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IProdutoRepository
    {
        public Produto CreateProduto(Produto produto, FileStream file);
        public Produto GetProduto(Guid codigo);
        public List<Produto> GetAllProdutos();
        public Produto UpdateProduto(Produto produto);
        public Produto RemoveProduto(Produto produto);
    }
}
