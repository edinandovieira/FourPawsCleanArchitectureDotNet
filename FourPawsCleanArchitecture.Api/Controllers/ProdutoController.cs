using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Application.Services;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;

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
        public ActionResult UpdateProduto([FromRoute] Guid codigo, [FromForm] ProductInput productInput, [FromForm] string status, [FromForm] IFormFile? file)
        {
            if (file != null)
            {
                var fileName = file.FileName;

                var filestream = new FileStream(fileName, FileMode.Create);

                file.CopyTo(filestream);

                var response = _produtoService.UpdateProduto(codigo, productInput, status, fileName, filestream);

                filestream.Close();

                System.IO.File.Delete(fileName);


                return Ok(response);
            }
            else
            {
                string fileName = null;

                FileStream filestream = null;

                var response = _produtoService.UpdateProduto(codigo, productInput, status, fileName, filestream);

                return Ok(response);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("avatar/{codigo:guid}")]
        public ActionResult GetRacaAvatar([FromRoute] Guid codigo)
        {
            var response = _produtoService.GetProduto(codigo);

            string path = $@"../FourPawsCleanArchitecture.Infraestructure/{response.Arquivo}";
            string tipoMime = "image/jpeg";

            byte[] fileBytes = System.IO.File.ReadAllBytes(path);

            return File(fileBytes, tipoMime);
        }
    }
}
