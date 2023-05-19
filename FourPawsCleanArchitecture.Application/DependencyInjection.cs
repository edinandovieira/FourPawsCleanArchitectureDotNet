using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
                .AddScoped<IProdutoService, ProdutoService>();
    }
}
