using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Application.Services;
using FourPawsCleanArchitecture.Domain.Models;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FourPawsCleanArchitecture.Api.Controllers
{
    [Route("v1/venda")]
    [ApiController]
    public class VendaController : Controller
    {
        private readonly IVendaService _vendaService;

        public VendaController(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        [Authorize]
        [HttpGet]
        public ActionResult GetAll()
        {
            var sales = _vendaService.GetAllSale();
            return Ok(sales);
        }

        [Authorize]
        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult Get(Guid codigo)
        {
            var sales = _vendaService.GetSale(codigo);

            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            string json = JsonSerializer.Serialize(sales, options);

            return Ok(json);
        }

        [Authorize]
        [HttpPost]
        public ActionResult CreateSale(List<VendaInput> venda)
        {
            var response = _vendaService.CreateSale(venda);
            return Ok(response);
        }

        /*[Authorize]
        [HttpPut]
        [Route("{codigo:guid}")]
        public ActionResult UpdateSale([FromRoute] Guid codigo, VendaInput venda, string status)
        {
            var response = _vendaService.UpdateSale(codigo, venda, status);
            return Ok(response);
        }*/
    }
}
