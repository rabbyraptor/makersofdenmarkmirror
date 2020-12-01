using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MakersOfDenmark.Models;

namespace MakersOfDenmark.Controllers
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
            List<HomeViewModel> home = new List<HomeViewModel>
            {
                new HomeViewModel() { Id = 1, Title = "FabLab UCL", Address = "Seebladsgade 1, 5000 Odense C", ImgUrl = "/img/home/fablab-ucl.jpeg"},
                new HomeViewModel() { Id = 2, Title = "FabLab2 UCL", Address = "Seebladsgade 1, 5000 Odense C", ImgUrl = "/img/home/img-1-small580.jpg"},
                new HomeViewModel() { Id = 3, Title = "FabLab3 UCL", Address = "Seebladsgade 1, 5000 Odense C", ImgUrl = "/img/home/IMG_2678.JPG"},
                new HomeViewModel() { Id = 4, Title = "FabLab4 UCL", Address = "Seebladsgade 1, 5000 Odense C", ImgUrl = "/img/home/fablabodense.jpg"}
            };
            return View(home);
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
