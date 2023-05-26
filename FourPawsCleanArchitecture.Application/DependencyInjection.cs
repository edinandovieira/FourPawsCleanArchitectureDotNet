using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Application.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace FourPawsCleanArchitecture.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddIoCApp(this IServiceCollection services,
            IConfiguration configuration) => services
                .AddScoped<ICategoriaService, CategoriaService>()
                .AddScoped<IUsuarioService, UsuarioService>()
                .AddScoped<IFeriadoService, FeriadoService>()
                .AddScoped<IServicoService, ServicoService>()
                .AddScoped<IRacaService, RacaService>()
                .AddScoped<IProdutoService, ProdutoService>()
                .AddScoped<ILoginService, LoginService>();

        public static IServiceCollection AddMapper(this IServiceCollection services,
            IConfiguration configuration) => services
                .AddSingleton(AutoMapperConfig.Configure());

        public static void AddJwtAuth(this IServiceCollection services,
            IConfiguration configuration)
        {
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateActor = true,
                            ValidateAudience = true,
                            ValidateIssuer = true,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true,
                            ClockSkew = TimeSpan.Zero,
                            ValidIssuer = configuration["JWT:Issuer"],
                            ValidAudience = configuration["JWT:Audience"],
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:SecretKey"]))
                        };
                    });
        }
    }
}
