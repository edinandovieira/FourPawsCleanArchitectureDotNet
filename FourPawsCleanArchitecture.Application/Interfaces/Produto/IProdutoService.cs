using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IProdutoService
    {
        public Produto CreateProduto(RProdutoRequest rProdutoRequest);
        public ProdutoDTO GetProduto(Guid codigo);
        public List<ProdutoDTO> GetAllProduto();
        public Produto UpdateProduto(Guid codigo, RProdutoRequest rProdutoRequest);
        public Produto RemoveProduto(Guid codigo);
    }
}
