using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface ICategoriaRepository
    {
        List<Categoria> GetAllCategory();
        Categoria GetCategory(Guid codigo);
        Categoria CreateCategory(Categoria categoria);
        Categoria UpdateCategory(Categoria categoria);
        Categoria RemoveCategory(Categoria categoria);
    }
}
