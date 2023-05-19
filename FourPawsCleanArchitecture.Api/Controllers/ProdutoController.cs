using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        public ActionResult CreateProduto(RProdutoRequest rProdutoRequest)
        {
            var response = _produtoService.CreateProduto(rProdutoRequest);
            return Ok(response);
        }

        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult GetProduto(Guid codigo)
        {
            var response = _produtoService.GetProduto(codigo);
            return Ok(response);
        }

        [HttpGet]
        public ActionResult GetAllProdutos()
        {
            var response = _produtoService.GetAllProdutos;
            return Ok(response);
        }

        [HttpPut]
        [Route("{codigo:guid}")]
        public ActionResult UpdateProduto([FromRoute] Guid codigo, RProdutoRequest rProdutoRequest)
        {
            var response = _produtoService.UpdateProduto(codigo, rProdutoRequest);
            return Ok(response);
        }
    }
}
