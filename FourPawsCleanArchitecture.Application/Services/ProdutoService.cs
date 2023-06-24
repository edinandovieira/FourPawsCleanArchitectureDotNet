using AutoMapper;
using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;
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

        public ProdutoDTO CreateProduto(ProductInput productinput, string filename, FileStream file)
        {
            var newProduto = new Produto
            {
                Codigo = new Guid(),
                Nome = productinput.nome,
                CodigoCategoria = productinput.codigoCategoria,
                Unidade = productinput.unidade,
                Estoque = productinput.estoque,
                Preco = productinput.preco,
                Arquivo = $"Assets/Products/{filename}"
            };
            _repository.CreateProduto(newProduto, file);

            ProdutoDTO produtoDTO = _mapper.Map<ProdutoDTO>(newProduto);
            return produtoDTO;
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
