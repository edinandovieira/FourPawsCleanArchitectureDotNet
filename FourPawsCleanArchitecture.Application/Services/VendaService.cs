using AutoMapper;
using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendarepository;
        private readonly IProdutoRepository _produtopository;
        private readonly IMapper _mapper;

        public VendaService(IVendaRepository vendarepository, IProdutoRepository produtopository, IMapper mapper)
        {
            _vendarepository = vendarepository;
            _produtopository = produtopository;
            _mapper = mapper;
        }

        public List<Venda> CreateSale(List<VendaInput> venda)
        {
            List<Venda> newSale = new List<Venda>();
            List<Produto> newProduct = new List<Produto>();

            Guid codigo = Guid.NewGuid();
            foreach (var sale in venda)
            {
                var product = _produtopository.GetProduto(sale.codigoproduto);
                int avaible = product.Estoque;

                if (avaible < sale.quantidade)
                {
                    throw new NotImplementedException();
                }

                newSale.Add(
                    new Venda
                    {
                        Codigo = Guid.NewGuid(),
                        CodigoVenda = codigo,
                        CodigoCliente = sale.codigocliente,
                        CodigoProduto = sale.codigoproduto,
                        Preco = sale.preco,
                        Quantidade = sale.quantidade
                    }
                );

                product.Estoque = avaible - sale.quantidade;

                newProduct.Add( product );
            }

            var response = _vendarepository.CreateSale(newSale, newProduct);
            return response;
        }

        public List<VendaList> GetAllSale()
        {
            var response = _vendarepository.GetAllSale();
            return response;
        }

        public List<Venda> GetSale(Guid codigo)
        {
            var response = _vendarepository.GetSale(codigo);
            return response;
        }

        public Venda RemoveSale(Guid codigo)
        {
            throw new NotImplementedException();
        }

        /*public Venda UpdateSale(Guid codigo, VendaInput venda, string status)
        {
            var newSale = _vendarepository.GetSale(codigo);

            newSale.CodigoCliente = venda.codigocliente;
            newSale.CodigoProduto = venda.codigoproduto;
            newSale.Preco = venda.preco;
            newSale.Quantidade = venda.quantidade;
            newSale.Status = status;

            var response = _vendarepository.UpdateSale(newSale);
            return response;
        }*/
    }
}
