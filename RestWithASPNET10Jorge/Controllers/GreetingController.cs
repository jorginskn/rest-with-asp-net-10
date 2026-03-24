using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10Jorge.Model;

namespace RestWithASPNET10Jorge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {
        private static long _counter = 0;
        private static readonly string _template = "Hello,{0}!";

        private readonly ILogger<GreetingController> _logger;

        public GreetingController(ILogger<GreetingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Greeting Get([FromQuery] string name= "World")
        {
            var id = Interlocked.Increment(ref _counter);
            var content = string.Format(_template, name);
            return new Greeting(1, content);
        }
    }
}
