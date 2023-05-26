using FourPawsCleanArchitecture.Application.Helpers;
using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Infraestructure.Persistence;

namespace FourPawsCleanArchitecture.Infraestructure.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly SqlServeDbContext _db;

        public LoginRepository(SqlServeDbContext db)
        {
            _db = db;
        }

        public Usuario CreateToken(LoginInput loginInput)
        {
            var response = _db.Usuarios.FirstOrDefault(c => c.Nome == loginInput.login && c.Senha == HashHelper.ComputeHash(loginInput.password));
            return response;
        }
    }
}
