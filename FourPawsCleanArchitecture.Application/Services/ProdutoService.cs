using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;
using FourPawsCleanArchitecture.Domain.Responses;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public Produto CreateProduto(RProdutoRequest rProdutoRequest)
        {
            var newProduto = new Produto
            {
                Codigo = new Guid(),
                Nome = rProdutoRequest.Nome,
                CodigoCategoria = rProdutoRequest.CodigoCategoria,
                Unidade = rProdutoRequest.Unidade,
                Estoque = rProdutoRequest.Estoque,
                Preco = rProdutoRequest.Preco,
                Arquivo = rProdutoRequest.Arquivo,
                Status = rProdutoRequest.Status
            };
            _repository.CreateProduto(newProduto);

            return newProduto;
        }

        public List<Produto> GetAllProdutos()
        {
            var response = _repository.GetAllProdutos();
            return response;
        }

        public Produto GetProduto(Guid codigo)
        {
            return _repository.GetProduto(codigo);
        }

        public Produto RemoveProduto(Guid codigo)
        {
            throw new NotImplementedException();
        }

        public Produto UpdateProduto(Guid codigo, RProdutoRequest rProdutoRequest)
        {
            var newProduto = new Produto
            {
                Codigo = codigo,
                Nome = rProdutoRequest.Nome,
                CodigoCategoria = rProdutoRequest.CodigoCategoria,
                Unidade = rProdutoRequest.Unidade,
                Estoque = rProdutoRequest.Estoque,
                Preco = rProdutoRequest.Preco,
                Arquivo = rProdutoRequest.Arquivo,
                Status = rProdutoRequest.Status
            };
            _repository.UpdateProduto(newProduto);

            return newProduto;
        }
    }
}
