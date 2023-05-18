using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IUsuarioService
    {
        Usuario CreateUser(Usuario usuario);
        Usuario GetUser(Guid codigo);
        List<Usuario> GetAllUser();
        Usuario RemoveUser(Usuario usuario);
        Usuario UpdateUser(Usuario usuario);
    }
}
