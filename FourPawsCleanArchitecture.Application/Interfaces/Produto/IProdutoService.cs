using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IProdutoService
    {
        public ProdutoDTO CreateProduto(ProductInput productinput, string filename, FileStream file);
        public ProdutoDTO GetProduto(Guid codigo);
        public List<ProdutoDTO> GetAllProduto();
        public Produto UpdateProduto(Guid codigo, ProductInput productinput, string status, string? filename, FileStream? file);
        public Produto RemoveProduto(Guid codigo);
    }
}
