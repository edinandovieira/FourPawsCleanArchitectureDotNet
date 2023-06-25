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

        public Produto CreateProduto(Produto produto, FileStream file)
        {
            _db.Produtos.Add(produto);
            _db.SaveChanges();

            string path = $@"../FourPawsCleanArchitecture.Infraestructure/{produto.Arquivo}";

            using (var filestream = new FileStream(path, FileMode.Create))
            {
                file.Position = 0;
                file.CopyTo(filestream);
            }

            return produto;
        }

        public List<Produto> GetAllProdutos()
        {
            var produto = _db.Produtos.ToList();
            return produto;
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

        public Produto UpdateProduto(Produto produto, FileStream? file = null)
        {
            _db.Produtos.Update(produto);
            _db.SaveChanges();

            if (file != null)
            {
                string path = $@"../FourPawsCleanArchitecture.Infraestructure/{produto.Arquivo}";

                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    file.Position = 0;
                    file.CopyTo(filestream);
                }
            }

            return produto;
        }
    }
}
