using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VotingCore.AppDbContext;
using VotingCore.Models;
using VotingCore.Services;

namespace VotingCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        private readonly EVotingDbContext _db;
        public HomeController(ILogger<HomeController> logger,IUserService userService, IEmailService emailService, EVotingDbContext db)
        {
            _logger = logger;
            _userService = userService;
            _emailService = emailService;
            _db = db;

        }

        public async Task< IActionResult> Index()
        {

            return View(_db.Elections.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public ActionResult Candidate()
        {
            return RedirectToAction("Index", "ElectionCandidate");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
