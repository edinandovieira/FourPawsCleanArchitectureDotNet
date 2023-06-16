using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Authorization;
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
        [Consumes("multipart/form-data")]
        public ActionResult<Raca> CreateRaca([FromForm] string nome,[FromForm] IFormFile file)
        {
            var fileName = file.FileName;

            var filestream = new FileStream(fileName, FileMode.Create);

            file.CopyTo(filestream);

            var response = _racaservice.CreateRaca(nome, fileName , filestream);

            filestream.Close();

            System.IO.File.Delete(fileName);

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

        [Authorize]
        [HttpGet]
        [Route("avatar/{codigo:guid}")]
        public ActionResult GetRacaAvatar([FromRoute] Guid codigo)
        {
            var response = _racaservice.GetRaca(codigo);

            string path = $@"../FourPawsCleanArchitecture.Infraestructure/{response.Avatar}";
            string tipoMime = "image/jpeg";

            byte[] fileBytes = System.IO.File.ReadAllBytes(path);

            return File(fileBytes, tipoMime);
        }
    }
}
