using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Infraestructure.Persistence;
using System.Linq;

namespace FourPawsCleanArchitecture.Infraestructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly SqlServeDbContext _db;

        public CategoriaRepository(SqlServeDbContext db)
        {
            _db = db;
        }

        public Categoria CreateCategory(Categoria categoria)
        {
            _db.Categorias.Add(categoria);
            _db.SaveChanges();

            return categoria;
        }

        public Categoria RemoveCategory(Categoria categoria)
        {
            _db.Categorias.Remove(categoria);
            _db.SaveChanges();

            return categoria;
        }

        public List<Categoria> GetAllCategory()
        {
            return _db.Categorias.ToList();
        }

        public Categoria GetCategory(Guid codigo)
        {
            return _db.Categorias.FirstOrDefault(x => x.Codigo == codigo);
        }

        public Categoria UpdateCategory(Categoria categoria)
        {
            _db.Update(categoria);
            _db.SaveChanges();

            return categoria;
        }
    }
}
