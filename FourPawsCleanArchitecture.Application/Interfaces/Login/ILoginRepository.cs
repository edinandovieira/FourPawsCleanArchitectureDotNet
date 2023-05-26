using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface ILoginRepository
    {
        public Usuario CreateToken(LoginInput loginInput);
    }
}
