using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstBackendProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        // GET localhost:xx/api/Welcome -> "Hello 5125!"
        [HttpGet]
        public string Get()
        {
            return "Hello 5125!";
        }
    }
}
