using Microsoft.AspNetCore.Mvc;
using MyProjectASPNETCORE.Models;
using System.Diagnostics;

namespace MyProjectASPNETCORE.Controllers
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
        [HttpGet]
        public ViewResult MyForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult MyForm(SharedTask listtask)
        {
            
                Repo.AddProduct(listtask);
                return View("Thank",listtask);
            
            
        }
        public ViewResult MyListTasks()
        {
            
            return View(Repo.products);
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