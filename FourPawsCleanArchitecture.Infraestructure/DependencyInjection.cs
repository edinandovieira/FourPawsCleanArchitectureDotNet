using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Infraestructure.Persistence;
using FourPawsCleanArchitecture.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FourPawsCleanArchitecture.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<SqlServeDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Sql")));

            return services;
        }

        public static IServiceCollection AddIoCInfra(this IServiceCollection services,
            IConfiguration configuration) => services
                .AddScoped<ICategoriaRepository, CategoriaRepository>()
                .AddScoped<IUsuarioRepository, UsuarioRepository>()
                .AddScoped<IFeriadoRepository, FeriadoRepository>()
                .AddScoped<IServicoRepository, ServicoRepository>()
                .AddScoped<IRacaRepository, RacaRepository>()
                .AddScoped<IProdutoRepository, ProdutoRepository>()
                .AddScoped<ILoginRepository, LoginRepository>();
    }
}
