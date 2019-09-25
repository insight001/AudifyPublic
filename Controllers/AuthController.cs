using Audify.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Audify.Controllers
{
    public class AuthController : Controller
    {
        public readonly DataContext _context;
        public AuthController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("/")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("Auth/LoginPost")]
        [HttpPost]
        public IActionResult LoginPost(LoginModel login)
        {
            var User = _context.Users.Where(x => x.UserName.ToLower() == login.Username.ToLower() && x.UserPassword == login.Password).FirstOrDefault();
            if (User == null)
                return View("Login");
            return RedirectToAction("Dashboard", new { name = User.BusinessName});
        }

        [HttpGet]
        [Route("Auth/Dashboard")]
        public ActionResult Dashboard(string name)
        {

            ViewBag.name = name;
            return View();
        }
        [HttpGet]
        [Route("Auth/Analytics")]
        public ActionResult Analytics()
        {
            return View();
        }
        [HttpGet]
        [Route("Auth/Logout")]
        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
        public class LoginModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

    }
}