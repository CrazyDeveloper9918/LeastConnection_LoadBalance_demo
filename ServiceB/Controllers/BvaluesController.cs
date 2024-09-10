using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BvaluesController : ControllerBase
    {
        [HttpGet("getValue")]

        public string Get()
        {
            return "this is B Service";
        }
    }
}
