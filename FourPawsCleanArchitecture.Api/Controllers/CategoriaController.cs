using FourPawsCleanArchitecture.Application.DTOs;
using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FourPawsCleanArchitecture.Api.Controllers
{
    [Route("v1/categoria")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAll()
        {
            var categorias = _categoriaService.GetAllCategory();
            return Ok(categorias);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult Get(Guid codigo)
        {
            var categoria = _categoriaService.GetCategory(codigo);
            return Ok(categoria);
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreateCategoria(RCategoriaRequest rCategoriaRequest)
        {
            var response = _categoriaService.CreateCategory(rCategoriaRequest);
            return Ok(response);
        }

        [Authorize]
        [HttpPut]
        [Route("{codigo:guid}")]
        public ActionResult UpdateCategory([FromRoute] Guid codigo, CategoryInput categoryInput)
        {
            var response = _categoriaService.UpdateCategory(codigo, categoryInput);
            return Ok(response);
        }
    }
}
