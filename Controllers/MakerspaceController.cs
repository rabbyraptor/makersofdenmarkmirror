using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MakersOfDenmark.Models;

namespace MakersOfDenmark.Controllers
{
    public class Makerspace : Controller
    {
        // 
        // GET: /Makerspace/

        public IActionResult Index()
        {
            var makerspace = new Models.Makerspace { Id = "1" };
            return View(makerspace);
        }

        // 
        // GET: /Makerspace/Id/ 

        public IActionResult Id(string id)
        {
            var makerspace = new Models.Makerspace { Id = id, Title = "FabLab UCL", Address = "Seebladsgade 1, 5000 Odense C", Email = "fablab@ucl.dk", HeaderImage = "/img/makerspace/makerspace-header.jpg" };
            return View(makerspace);
        }
    }
}