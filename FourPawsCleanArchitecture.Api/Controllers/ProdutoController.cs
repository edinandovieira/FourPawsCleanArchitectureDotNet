using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Application.Services;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FourPawsCleanArchitecture.Api.Controllers
{
    [Route("v1/produto")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [Authorize]
        [HttpPost]
        [Consumes("multipart/form-data")]
        public ActionResult CreateProduto([FromForm] ProductInput productInput, [FromForm] IFormFile file)
        {
            var fileName = file.FileName;

            var filestream = new FileStream(fileName, FileMode.Create);
            file.CopyTo(filestream);

            var response = _produtoService.CreateProduto(productInput, fileName, filestream);

            filestream.Close();

            System.IO.File.Delete(fileName);

            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult GetProduto(Guid codigo)
        {
            var response = _produtoService.GetProduto(codigo);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult GetAllProduto()
        {
            var response = _produtoService.GetAllProduto();
            return Ok(response);
        }

        [Authorize]
        [HttpPut]
        [Route("{codigo:guid}")]
        public ActionResult UpdateProduto([FromRoute] Guid codigo, RProdutoRequest rProdutoRequest)
        {
            var response = _produtoService.UpdateProduto(codigo, rProdutoRequest);
            return Ok(response);
        }
    }
}
