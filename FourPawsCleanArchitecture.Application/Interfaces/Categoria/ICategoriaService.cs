using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface ICategoriaService
    {
        List<Categoria> GetAllCategory();
        Categoria GetCategory(Guid codigo);
        Categoria CreateCategory(RCategoriaRequest rCategoriaRequest);
        Categoria UpdateCategory(Categoria categoria);
        Categoria RemoveCategory(Categoria categoria);
    }
}
