using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Infraestructure.Persistence;

namespace FourPawsCleanArchitecture.Infraestructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly SqlServeDbContext _db;

        public ProdutoRepository(SqlServeDbContext db)
        {
            _db = db;
        }

        public Produto CreateProduto(Produto produto)
        {
            _db.Produtos.Add(produto);
            _db.SaveChanges();

            return produto;
        }

        public List<Produto> GetAllProdutos()
        {
            return _db.Produtos.ToList();
        }

        public Produto GetProduto(Guid codigo)
        {
            return _db.Produtos.FirstOrDefault(c => c.Codigo == codigo);
        }

        public Produto RemoveProduto(Produto produto)
        {
            _db.Produtos.Remove(produto);
            _db.SaveChanges();

            return produto;
        }

        public Produto UpdateProduto(Produto produto)
        {
            _db.Produtos.Update(produto);
            _db.SaveChanges();

            return produto;
        }
    }
}
