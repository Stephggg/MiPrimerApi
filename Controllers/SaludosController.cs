// Autor: Stephany Flores

using Microsoft.AspNetCore.Mvc;

namespace MiPrimerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaludosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hola desde ASP.NET Core");
        }
    }
}
