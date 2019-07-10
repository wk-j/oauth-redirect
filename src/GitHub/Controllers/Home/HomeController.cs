using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GitHub.Controllers.Home {

    public class IndexModel {
        public string GetScript() {
            var asm = typeof(KFontend.KFrontendClass).Assembly;
            var js = asm.GetManifestResourceNames().Where(x => x.StartsWith("KFrontend.wwwroot.web") && x.EndsWith(".js")).FirstOrDefault();
            return js.Replace("KFrontend.wwwroot.", "/");
        }
        public string GetCss() {
            var asm = typeof(KFontend.KFrontendClass).Assembly;
            var js = asm.GetManifestResourceNames().Where(x => x.StartsWith("KFrontend.wwwroot.web") && x.EndsWith(".css")).FirstOrDefault();
            return js.Replace("KFrontend.wwwroot.", "/");
        }
    }

    public class HomeController : Controller {
        public IActionResult Index() {
            if (!User.Identity.IsAuthenticated) {
                return Redirect("/Account/Login");
            } else {
                // return Redirect("/index.html");
                return PartialView(new IndexModel());
            }
        }
    }
}