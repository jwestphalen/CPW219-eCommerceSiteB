using Microsoft.AspNetCore.Mvc;

namespace CPW219_eCommerceSiteB.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
