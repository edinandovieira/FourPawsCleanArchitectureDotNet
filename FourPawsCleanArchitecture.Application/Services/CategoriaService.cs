using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriarepository;

        public CategoriaService(ICategoriaRepository categoriarepository)
        {
            _categoriarepository = categoriarepository;
        }

        public Categoria CreateCategory(RCategoriaRequest rCategoriaRequest)
        {
            var newCategoria = new Categoria
            {
                Codigo = new Guid(),
                Nome = rCategoriaRequest.nome
            };

            _categoriarepository.CreateCategory(newCategoria);
            return newCategoria;
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
