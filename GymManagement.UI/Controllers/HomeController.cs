using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICampignService _campaignService;

        public HomeController(ILogger<HomeController> logger, ICampignService campaignService)
        {
            _logger = logger;
            _campaignService = campaignService;
        }

        public IActionResult Index()
        {
            var campaigns = _campaignService.GetAll();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
