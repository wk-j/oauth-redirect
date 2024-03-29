using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace GitHub.Controllers {
    [Route("[controller]/[action]")]
    public class AccountController : Controller {
        public IActionResult Login(string returnUrl = "/home") {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
        }
    }
}