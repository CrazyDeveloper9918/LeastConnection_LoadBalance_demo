using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaluesController : ControllerBase
    {
        [HttpGet("getValue")]

        public string Get()
        {
            return "this is A Service";
        }
    }
}
