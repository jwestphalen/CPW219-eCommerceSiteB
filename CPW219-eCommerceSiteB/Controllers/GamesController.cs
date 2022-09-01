using Microsoft.AspNetCore.Mvc;

namespace CPW219_eCommerceSiteB.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
