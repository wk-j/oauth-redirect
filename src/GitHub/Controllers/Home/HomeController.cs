using Microsoft.AspNetCore.Mvc;

namespace GitHub.Controllers.Home {
    public class HomeController : Controller {
        public IActionResult Index() {
            if (!User.Identity.IsAuthenticated) {
                return Redirect("/Account/Login");
            } else {
                // return Redirect("/index.html");
                return PartialView();
            }
        }
    }
}