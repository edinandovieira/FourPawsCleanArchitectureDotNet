using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Application.Services;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Mvc;

namespace FourPawsCleanArchitecture.Api.Controllers
{
    [Route("v1/servico")]
    [ApiController]
    public class ServicoController : Controller
    {
        private readonly IServicoService _servicoService;

        public ServicoController(IServicoService servicoService)
        {
            _servicoService = servicoService;
        }

        [HttpGet]
        public ActionResult<List<Servico>> GetAll()
        {
            var servicos = _servicoService.GetAllServico();
            return Ok(servicos);
        }

        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult<Servico> GetServico(Guid codigo)
        {
            var servicos = _servicoService.GetServico(codigo);
            return Ok(servicos);
        }

        [HttpPost]
        public ActionResult<Servico> CreateServico(RServicoPrincipal rServicoPrincipal)
        {
            var Servico = _servicoService.CreateServico(rServicoPrincipal);
            return Ok(Servico);
        }

        [HttpPut]
        [Route("{codigo:guid}")]
        public ActionResult<Servico> UpdateCategory([FromRoute] Guid codigo, RServicoPrincipal rServicoPrincipal)
        {
            var newServico = _servicoService.GetServico(codigo);

            newServico.Nome = rServicoPrincipal.Nome;
            newServico.Status = rServicoPrincipal.Status;

            newServico = _servicoService.UpdateServico(newServico);

            return Ok(newServico);
        }
    }
}
