using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;
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

        [HttpGet]
        public ActionResult<List<Usuario>> GetAll()
        {
            var usuarios = _usuarioService.GetAllUser();
            return Ok(usuarios);
        }

        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult<Usuario> Get(Guid codigo)
        {
            var usuario = _usuarioService.GetUser(codigo);
            return Ok(usuario);
        }

        [HttpPost]
        public ActionResult<Usuario> PostCategory(Usuario usuario)
        {
            var Usuario = _usuarioService.CreateUser(usuario);
            return Ok(usuario);
        }

        [HttpPut]
        [Route("{codigo:guid}")]
        public ActionResult<Usuario> UpdateCategory([FromRoute] Guid codigo, RUpdateUsuario rUpdateUsuario)
        {
            var newUsuario = _usuarioService.GetUser(codigo);

            newUsuario.Nome = rUpdateUsuario.Nome;
            newUsuario.Senha = rUpdateUsuario.Senha;
            newUsuario.Tipo = rUpdateUsuario.Tipo;
            newUsuario.Status = rUpdateUsuario.Status;

            newUsuario = _usuarioService.UpdateUser(newUsuario);

            return Ok(newUsuario);
        }
    }
}
