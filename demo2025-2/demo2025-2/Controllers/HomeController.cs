using demo2025_2.Models;
using demo2025_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;

namespace demo2025_2.Controllers
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

            var viewModel = new PrivacyPageViewModel
            {
                People = new List<PeopleViewModel>
                {

                new PeopleViewModel{Id= 1,Name="Bill"},
                new PeopleViewModel{ Id = 2, Name = "Steve" },
                new PeopleViewModel{ Id = 3, Name = "John" }
                },
                Customer = new CustomerViewModel { Id = 4, Name = "Kyle", Role = "Guy" }

            };
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
