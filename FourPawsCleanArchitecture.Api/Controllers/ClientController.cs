using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourPawsCleanArchitecture.Api.Controllers
{
    [Route("v1/cliente")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientService _service;

        public ClientController(IClientService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _service.GetAllClient();
            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult GetAll(Guid codigo)
        {
            var response = _service.GetClient(codigo);
            return Ok(response);
        }
    }
}
