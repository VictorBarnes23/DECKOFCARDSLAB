using DECK_OF_CARDS_LAB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DECK_OF_CARDS_LAB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DOC()
        {
            DOC result = DOCDAL.GetDOC();
            if(result.Remaining == 0)
            {
                DOCDAL.GetShuffle();
                result = DOCDAL.GetDOC();
            }
            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
