using AutoMapper;
using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Application.Helpers;
using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Domain.Records;
using System.Collections.Generic;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuariorepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuariorepository, IMapper mapper)
        {
            _usuariorepository = usuariorepository;
            _mapper = mapper;
        }
        public UsuarioInput CreateUser(UsuarioInput usuarioInput)
        {
            var newUser = new Usuario
            {
                Codigo = Guid.NewGuid(),
                Nome = usuarioInput.nome,
                Senha = HashHelper.ComputeHash(usuarioInput.senha),
                Tipo = usuarioInput.tipo,
                Status = "A"
            };

            var user = _usuariorepository.CreateUser(newUser);
            UsuarioInput response = _mapper.Map<UsuarioInput>(user);
            return response;
        }

        public List<UsuarioDTOReponse> GetAllUser()
        {
            var users = _usuariorepository.GetAllUser();
            List<UsuarioDTOReponse> response = _mapper.Map<List<UsuarioDTOReponse>>(users);
            return response;
        }

        public UsuarioDTOReponse GetUser(Guid codigo)
        {
            var user = _usuariorepository.GetUser(codigo);
            UsuarioDTOReponse response = _mapper.Map<UsuarioDTOReponse>(user);
            return response;
        }

        public UsuarioDTOReponse RemoveUser(Usuario usuario)
        {
            var user = _usuariorepository.RemoveUser(usuario);
            UsuarioDTOReponse response = _mapper.Map<UsuarioDTOReponse>(user);
            return response;
        }

        public UsuarioDTOReponse UpdateUser(Guid codigo, RUpdateUsuario rUpdateUsuario)
        {
            var newUsuario = _usuariorepository.GetUser(codigo);

            newUsuario.Nome = rUpdateUsuario.Nome;
            newUsuario.Senha = HashHelper.ComputeHash(rUpdateUsuario.Senha);
            newUsuario.Tipo = rUpdateUsuario.Tipo;
            newUsuario.Status = rUpdateUsuario.Status;

            var user = _usuariorepository.UpdateUser(newUsuario);
            UsuarioDTOReponse response = _mapper.Map<UsuarioDTOReponse>(user);
            return response;
        }
    }
}
