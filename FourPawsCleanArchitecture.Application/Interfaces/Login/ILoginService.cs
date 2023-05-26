using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface ILoginService
    {
        public Login CreateToken(LoginInput loginInput);
    }
}
