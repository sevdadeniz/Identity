using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Autentication.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[Authorized(Roles="Admin")]
        [Authorize]
        public IActionResult Security()
        {
            return View();
        }
    }
}
