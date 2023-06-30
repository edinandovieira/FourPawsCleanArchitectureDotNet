using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourPawsCleanArchitecture.Api.Controllers
{
    [Route("v1/test")]
    [ApiController]
    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok("Success");
        }
    }
}
