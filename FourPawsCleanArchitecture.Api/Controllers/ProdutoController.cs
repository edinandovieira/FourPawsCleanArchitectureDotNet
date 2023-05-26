using FourPawsCleanArchitecture.Application.Interfaces;
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
        public ActionResult CreateProduto(RProdutoRequest rProdutoRequest)
        {
            var response = _produtoService.CreateProduto(rProdutoRequest);
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
