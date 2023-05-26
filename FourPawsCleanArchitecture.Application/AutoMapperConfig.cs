using AutoMapper;
using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;

namespace FourPawsCleanArchitecture.Application
{
    public static class AutoMapperConfig
    {
        public static IMapper Configure()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Produto, ProdutoDTO>();
                config.CreateMap<Usuario, Login>();
                config.CreateMap<Usuario, UsuarioDTOReponse>();
                config.CreateMap<Usuario, UsuarioInput>();
                config.CreateMap<Categoria, CategoriaDTO>();
            });

            return mapperConfig.CreateMapper();
        }
    }
}
