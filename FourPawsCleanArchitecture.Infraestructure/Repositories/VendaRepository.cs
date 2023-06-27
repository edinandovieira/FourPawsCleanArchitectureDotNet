using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FourPawsCleanArchitecture.Infraestructure.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly SqlServeDbContext _db;

        public VendaRepository(SqlServeDbContext db)
        {
            _db = db;
        }

        public List<Venda> CreateSale(List<Venda> venda, List<Produto> produto)
        {
            _db.Vendas.AddRange(venda);
            _db.SaveChanges();

            _db.Produtos.UpdateRange(produto);
            _db.SaveChanges();

            return venda;
        }

        public List<VendaList> GetAllSale()
        {
            return _db.Vendas
                .GroupBy(x => x.CodigoVenda)
                .Select(g => new VendaList(g.Key, g.Sum(p => p.Preco)))
                .ToList();
        }

        public List<Venda> GetSale(Guid codigo)
        {
            return _db.Vendas
                .Include(x => x.Clientes)
                .Include(x => x.Produtos)
                .Where(x => x.CodigoVenda == codigo)
                .ToList();
        }

        public Venda RemoveSale(Venda venda)
        {
            _db.Vendas.Remove(venda);
            _db.SaveChanges();

            return venda;
        }

        public Venda UpdateSale(Venda venda)
        {
            _db.Update(venda);
            _db.SaveChanges();

            return venda;
        }
    }
}
