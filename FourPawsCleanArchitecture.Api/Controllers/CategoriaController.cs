﻿using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;
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

        [HttpGet]
        public ActionResult<List<Categoria>> GetAll()
        {
            var categorias = _categoriaService.GetAllCategory();
            return Ok(categorias);
        }

        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult<Categoria> Get(Guid codigo)
        {
            var categoria = _categoriaService.GetCategory(codigo);
            return Ok(categoria);
        }

        [HttpPost]
        public ActionResult<Categoria> CreateCategoria(RCategoriaRequest rCategoriaRequest)
        {
            var response = _categoriaService.CreateCategory(rCategoriaRequest);
            return Ok(response);
        }

        [HttpPut]
        [Route("{codigo:guid}")]
        public ActionResult<Categoria> UpdateCategory([FromRoute] Guid codigo, RCategoriaRequest rCategoriaRequest)
        {
            var newCategoria = _categoriaService.GetCategory(codigo);

            newCategoria.Nome = rCategoriaRequest.nome;

            newCategoria = _categoriaService.UpdateCategory(newCategoria);

            return Ok(newCategoria);
        }
    }
}
