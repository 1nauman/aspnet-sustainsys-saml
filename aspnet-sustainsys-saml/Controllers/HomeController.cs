using System.Security.Claims;
using System.Web.Mvc;

namespace aspnet_sustainsys_saml.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Secure()
        {
            var identity = System.Web.HttpContext.Current.User.Identity as ClaimsIdentity;
            return View(identity.Claims);
        }
    }
}