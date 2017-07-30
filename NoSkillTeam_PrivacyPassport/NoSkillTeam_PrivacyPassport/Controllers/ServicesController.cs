using Microsoft.AspNetCore.Mvc;

namespace NoSkillTeam_PrivacyPassport.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DIV()
        {
            return View();
        }
    }
}