using AutoMapper;
using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriarepository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriarepository, IMapper mapper)
        {
            _categoriarepository = categoriarepository;
            _mapper = mapper;
        }

        public CategoriaDTO CreateCategory(RCategoriaRequest rCategoriaRequest)
        {
            var newCategoria = new Categoria
            {
                Codigo = new Guid(),
                Nome = rCategoriaRequest.nome
            };

            _categoriarepository.CreateCategory(newCategoria);
            CategoriaDTO response = _mapper.Map<CategoriaDTO>(newCategoria);
            return response;
        }

        public CategoriaDTO GetCategory(Guid codigo)
        {
            var category = _categoriarepository.GetCategory(codigo);
            CategoriaDTO response = _mapper.Map<CategoriaDTO>(category);
            return response;
        }

        public List<CategoriaDTO> GetAllCategory()
        {
            var categorias = _categoriarepository.GetAllCategory();
            List<CategoriaDTO> response = _mapper.Map<List<CategoriaDTO>>(categorias);
            return response;
        }

        public CategoriaDTO RemoveCategory(Categoria categoria)
        {
            var category = _categoriarepository.RemoveCategory(categoria);
            CategoriaDTO response = _mapper.Map<CategoriaDTO>(category);
            return response;
        }

        public CategoriaDTO UpdateCategory(Guid codigo, RCategoriaRequest rCategoriaRequest)
        {
            var newCategoria = _categoriarepository.GetCategory(codigo);

            newCategoria.Nome = rCategoriaRequest.nome;

            var category = _categoriarepository.UpdateCategory(newCategoria);

            CategoriaDTO response = _mapper.Map<CategoriaDTO>(category);
            return response;
        }
    }
}
