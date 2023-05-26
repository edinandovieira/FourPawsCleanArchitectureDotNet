using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IUsuarioService
    {
        UsuarioInput CreateUser(UsuarioInput usuarioInput);
        UsuarioDTOReponse GetUser(Guid codigo);
        List<UsuarioDTOReponse> GetAllUser();
        UsuarioDTOReponse RemoveUser(Usuario usuario);
        UsuarioDTOReponse UpdateUser(Guid codigo, RUpdateUsuario rUpdateUsuario);
    }
}
