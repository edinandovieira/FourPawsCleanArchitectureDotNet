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

        public Produto UpdateProduto(Guid codigo, ProductInput productinput, string status, string? filename = null, FileStream? file = null)
        {
            var Produto = _repository.GetProduto(codigo);

            string path = $@"../FourPawsCleanArchitecture.Infraestructure/{Produto.Arquivo}";

            Produto.Nome = productinput.nome;
            Produto.CodigoCategoria = productinput.codigoCategoria;
            Produto.Unidade = productinput.unidade;
            Produto.Estoque = productinput.estoque;
            Produto.Preco = productinput.preco;
            Produto.Status = status;

            if (!string.IsNullOrEmpty(filename))
            {
                Produto.Arquivo = $"Assets/Products/{filename}";
                var response = _repository.UpdateProduto(Produto, file);
                System.IO.File.Delete(path);
                return response;
            }
            else
            {
                var response = _repository.UpdateProduto(Produto, file);
                return response;

            }
        }
    }
}
