using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FourPawsCleanArchitecture.Api.Controllers
{
    [Route("v1/usuario")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<List<UsuarioDTOReponse>> GetAllUser()
        {
            var usuarios = _usuarioService.GetAllUser();
            return Ok(usuarios);
        }

        [Authorize]
        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult<UsuarioDTOReponse> GetUser(Guid codigo)
        {
            var usuario = _usuarioService.GetUser(codigo);
            return Ok(usuario);
        }

        [Authorize]
        [HttpPost]
        public ActionResult<UsuarioDTOReponse> CreateUser(UsuarioInput usuarioInput)
        {
            var Usuario = _usuarioService.CreateUser(usuarioInput);
            return Ok(Usuario);
        }

        [Authorize]
        [HttpPut]
        [Route("{codigo:guid}")]
        public ActionResult<UsuarioDTOReponse> UpdateCategory([FromRoute] Guid codigo, RUpdateUsuario rUpdateUsuario)
        {
            var response = _usuarioService.UpdateUser(codigo, rUpdateUsuario);

            return Ok(response);
        }
    }
}
