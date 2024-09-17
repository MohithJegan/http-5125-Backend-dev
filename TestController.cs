using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET Method => url => /test/method1
        [HttpGet(template:"Method1")]
        public string Method1()
        {
            return "Hello World";
        }

        // GET Method => url => /test/method2
        [HttpGet(template:"Method2")]
        public string Method2()
        {
            return "Hello 5125";
        }

        // POST Method => url => /test/method3
        [HttpPost(template:"Method3")]
        public string Method3()
        {
            return "The POST request";
        }
    }
}
