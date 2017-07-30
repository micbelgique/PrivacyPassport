
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using NoSkillTeam_PrivacyPassport.Services;

namespace NoSkillTeam_PrivacyPassport.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public HomeController(IStringLocalizer<HomeController> localizer, IEmailSender emailSender, ILoggerFactory loggerFactory)
        {
            _localizer = localizer;
            _emailSender = emailSender;
            _logger = loggerFactory.CreateLogger<AccountController>();
        }

        [Authorize]
        public IActionResult Dashboard()
        {
            return View();
        }

        [Authorize]
        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Dashboard");
            }

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
