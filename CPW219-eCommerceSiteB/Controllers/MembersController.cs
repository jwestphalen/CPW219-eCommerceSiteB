using CPW219_eCommerceSite.Data;
using CPW219_eCommerceSiteB.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPW219_eCommerceSiteB.Controllers
{
    public class MembersController : Controller
    {
        private readonly VideoGameContext _context;

        public MembersController(VideoGameContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel regModel)
        {
            if (ModelState.IsValid)
            {
                // Map RegisterViewModel data to Member object
                Member newMember = new()
                {
                    Email = regModel.Email,
                    Password = regModel.Password
                };

                _context.Members.Add(newMember);
                await _context.SaveChangesAsync();

                // Redirect to homepage
                return RedirectToAction("index", "Home");
            }
            
            return View(regModel);
        }
    }
}
