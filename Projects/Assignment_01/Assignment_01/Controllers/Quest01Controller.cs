using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Quest01Controller : ControllerBase
    {
        // <summary>
        //    This will return a Welcome message
        // </summary>

        [HttpGet(template: "Welcome")]
        public string Welcome() => "Welcome to 5125!";
    }
}
