using AutoMapper;
using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application
{
    public static class AutoMapperConfig
    {
        public static IMapper Configure()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                /*config.CreateMap<Produto, ProdutoDTO>()
                      .ForMember(dest => dest.C, opt => opt.MapFrom(src => src.));*/
                config.CreateMap<Produto, ProdutoDTO>();
            });

            return mapperConfig.CreateMapper();
        }
    }
}
