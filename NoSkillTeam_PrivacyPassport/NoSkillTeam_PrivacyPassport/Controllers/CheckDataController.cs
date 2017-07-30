using System;
using Microsoft.AspNetCore.Mvc;
using NoSkillTeam_PrivacyPassport.Data;

namespace NoSkillTeam_PrivacyPassport.Controllers
{
    public class CheckDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckData()
        {
            return RedirectToAction("Result");
        }

        public IActionResult Result()
        {

            return View();
        }
    }
}