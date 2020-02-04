using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using helloWorldAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace helloWorldAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly IGreeter _greeter;

        private readonly ILogger<HelloWorldController> _logger;



        public HelloWorldController(ILogger<HelloWorldController> logger, IGreeter greeter) 
        {
            _logger = logger;
            _greeter = greeter;
        }

        [HttpGet("world/hello")]
        public async Task<HelloWorld> GetHelloWorld()
        {
            var helloWorldString = _greeter.Greet();
            return await Task.FromResult(helloWorldString);
        }
    }
}
