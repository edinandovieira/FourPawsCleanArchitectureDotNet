using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Infraestructure.Persistence;

namespace FourPawsCleanArchitecture.Infraestructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SqlServeDbContext _db;

        public UsuarioRepository(SqlServeDbContext db)
        {
            _db = db;
        }
        public Usuario CreateUser(Usuario usuario)
        {
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();

            return usuario;
        }

        public List<Usuario> GetAllUser()
        {
            return _db.Usuarios.ToList();
        }

        public Usuario GetUser(Guid codigo)
        {
            return _db.Usuarios.FirstOrDefault(c => c.Codigo == codigo);
        }

        public Usuario RemoveUser(Usuario usuario)
        {
            _db.Usuarios.Remove(usuario);
            _db.SaveChanges();

            return usuario;
        }

        public Usuario UpdateUser(Usuario usuario)
        {
            _db.Usuarios.Update(usuario);
            _db.SaveChanges();

            return usuario;
        }
    }
}
