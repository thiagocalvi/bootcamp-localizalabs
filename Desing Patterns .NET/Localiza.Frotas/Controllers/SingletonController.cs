using Localiza.Frotas.Infra.Singleton;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.Frotas.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        [HttpGet()]

        public IActionResult Get()
        {
            var singleton = Singleton.Instance();
            return Ok(singleton);
        }
    }
}
