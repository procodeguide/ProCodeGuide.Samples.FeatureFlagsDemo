using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using ProCodeGuide.Samples.FeatureFlagsDemo.Models;
using System.Diagnostics;

namespace ProCodeGuide.Samples.FeatureFlagsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFeatureManager _featureManager;

        public HomeController(ILogger<HomeController> logger, IFeatureManager featureManager)
        {
            _logger = logger;
            _featureManager = featureManager;
        }

        public async Task<IActionResult> Index()
        {
            if (await _featureManager.IsEnabledAsync(nameof(FeatureFlags.MobileReview)))
            {
                ViewData["WelcomeMessage"] = "Welcome - Mobile Review Application";
            }
            else
            {
                ViewData["WelcomeMessage"] = "Welcome";
            }
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