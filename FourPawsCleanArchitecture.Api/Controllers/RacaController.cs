using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Application.Services;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourPawsCleanArchitecture.Api.Controllers
{
    [Route("v1/raca")]
    [ApiController]
    public class RacaController : Controller
    {
        private readonly IRacaService _racaservice;

        public RacaController(IRacaService racaService)
        {
            _racaservice = racaService;
        }

        [Authorize]
        [HttpPost]
        public ActionResult<Raca> CreateRaca(RRacaRequest rRacaRequest)
        {
            var response = _racaservice.CreateRaca(rRacaRequest);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult<Raca> GetRaca(Guid codigo)
        {
            var response = _racaservice.GetRaca(codigo);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult<List<Raca>> GetAllRacas()
        {
            var response = _racaservice.GetAllRacas();
            return Ok(response);
        }

        [Authorize]
        [HttpPut]
        [Route("{codigo:guid}")]
        public ActionResult<Raca> UpdateRaca([FromRoute] Guid codigo, RRacaRequest rRacaRequest)
        {
            var response = _racaservice.UpdateRaca(codigo, rRacaRequest);

            return Ok(response);
        }
    }
}
