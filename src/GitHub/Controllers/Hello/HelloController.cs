using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GitHub.Controllers.Hello {
    [Route("api/[controller]/[action]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class HelloController : ControllerBase {

        [HttpGet]
        public string Hello() {
            var settings = new JsonSerializerSettings {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            var json = JsonConvert.SerializeObject(this.User.Claims, Formatting.Indented, settings);
            Console.WriteLine(json);

            var id = User.FindFirst(ClaimTypes.NameIdentifier);
            Console.WriteLine("Id - {0}", id.Value);

            return "Hello";
        }
    }

    [Route("api/[action]/[controller]")]
    [Authorize]
    public class AController : ControllerBase {
        public string A() => "A";
    }
}