using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuariorepository;

        public UsuarioService(IUsuarioRepository usuariorepository)
        {
            _usuariorepository = usuariorepository;
        }
        public Usuario CreateUser(Usuario usuario)
        {
            _usuariorepository.CreateUser(usuario);
            return usuario;
        }

        public List<Usuario> GetAllUser()
        {
            var users = _usuariorepository.GetAllUser();
            return users;
        }

        public Usuario GetUser(Guid codigo)
        {
            return _usuariorepository.GetUser(codigo);
        }

        public Usuario RemoveUser(Usuario usuario)
        {
            _usuariorepository.RemoveUser(usuario);
            return usuario;
        }

        public Usuario UpdateUser(Usuario usuario)
        {
            _usuariorepository.UpdateUser(usuario);
            return usuario;
        }
    }
}
