using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface ICategoriaService
    {
        List<CategoriaDTO> GetAllCategory();
        CategoriaDTO GetCategory(Guid codigo);
        CategoriaDTO CreateCategory(RCategoriaRequest rCategoriaRequest);
        CategoriaDTO UpdateCategory(Guid codigo, CategoryInput categoryInput);
        CategoriaDTO RemoveCategory(Categoria categoria);
    }
}
