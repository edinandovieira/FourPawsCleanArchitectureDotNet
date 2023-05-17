using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriarepository;

        public CategoriaService(ICategoriaRepository categoriarepository)
        {
            _categoriarepository = categoriarepository;
        }

        public Categoria CreateCategory(Categoria categoria)
        {
            _categoriarepository.CreateCategory(categoria);
            return categoria;
        }

        public Categoria GetCategory(Guid codigo)
        {
            return _categoriarepository.GetCategory(codigo);
        }

        public List<Categoria> GetAllCategory()
        {
            var categorias = _categoriarepository.GetAllCategory();
            return categorias;
        }

        public Categoria RemoveCategory(Categoria categoria)
        {
            _categoriarepository.RemoveCategory(categoria);
            return categoria;
        }

        public Categoria UpdateCategory(Categoria categoria)
        {
            return _categoriarepository.UpdateCategory(categoria);
        }
    }
}
