using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Mvc;

namespace FourPawsCleanArchitecture.Api.Controllers
{
    [Route("v1/feriado")]
    [ApiController]
    public class FeriadoController : Controller
    {
        private readonly IFeriadoService _feriadoService;

        public FeriadoController(IFeriadoService feriadoService)
        {
            _feriadoService = feriadoService;
        }

        [HttpGet]
        public ActionResult<List<Feriado>> GetAll()
        {
            var feriados = _feriadoService.GetAllHolyday();
            return Ok(feriados);
        }

        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult<Feriado> Get(Guid codigo)
        {
            var feriado = _feriadoService.GetHolyday(codigo);
            return Ok(feriado);
        }

        [HttpPost]
        public ActionResult<Feriado> CreateHolyday(Feriado feriado)
        {
            var Feriado = _feriadoService.CreateHolyday(feriado);
            return Ok(feriado);
        }

        [HttpPut]
        [Route("{codigo:guid}")]
        public ActionResult<Feriado> UpdateHolyday([FromRoute] Guid codigo, RUpdateFeriado rUpdateFeriado)
        {
            var newFeriado = _feriadoService.GetHolyday(codigo);

            newFeriado.Nome = rUpdateFeriado.Nome;
            newFeriado.Data = rUpdateFeriado.Data.Date;
            newFeriado.Status = rUpdateFeriado.Status;

            newFeriado = _feriadoService.UpdateHolyday(newFeriado);

            return Ok(newFeriado);
        }

    }
}
