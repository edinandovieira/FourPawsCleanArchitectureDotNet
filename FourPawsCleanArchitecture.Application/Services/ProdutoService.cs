using AutoMapper;
using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;
using FourPawsCleanArchitecture.Domain.Responses;
using System.Collections.Generic;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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
        public List<ProdutoDTO> GetAllProduto()
        {
            List<Produto> produto = _repository.GetAllProdutos();
            List <ProdutoDTO> produtoDTO = _mapper.Map<List<ProdutoDTO>>(produto);
            return produtoDTO;
        }

        public ProdutoDTO GetProduto(Guid codigo)
        {
            Produto produto = _repository.GetProduto(codigo);
            ProdutoDTO produtoDTO = _mapper.Map<ProdutoDTO>(produto);
            return produtoDTO;
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
