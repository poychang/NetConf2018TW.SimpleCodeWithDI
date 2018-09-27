using AspNetCoreWebApp.Models;
using AspNetCoreWebApp.Services.SessionInfo;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataService _service;

        public HomeController(IDataService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(new SessionInfoViewModel() { SessionList = _service.FetchData() });
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
