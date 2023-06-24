using AutoMapper;
using FourPawsCleanArchitecture.Application.Helpers;
using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _repository;
        private readonly IMapper _mapper;
        private readonly string _secretKey;
        private readonly string _issuer;
        private readonly string _audience;
        private readonly double _exp;

        public LoginService(ILoginRepository repository, IMapper mapper, IConfiguration configuration)
        {
            _repository = repository;
            _mapper = mapper;
            _secretKey = configuration["JWT:SecretKey"];
            _issuer = configuration["JWT:Issuer"];
            _audience = configuration["JWT:Audience"];
            _exp = double.Parse(configuration["JWT:ExpiryTimeInSeconds"]);
        }

        public Login CreateToken(LoginInput loginInput)
        {
            var user = _repository.CreateToken(loginInput);
            Login login = _mapper.Map<Login>(user);

            var claims = new[]
            {
                new Claim("login", loginInput.login)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: claims,
                expires: DateTime.UtcNow.AddSeconds(_exp),
                signingCredentials: credentials
            );

            login.Token = new JwtSecurityTokenHandler().WriteToken(token);

            return login;        
        }
    }
}
