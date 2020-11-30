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
            var makerspace = new Models.Makerspace { Id = id };
            return View(makerspace);
        }
    }
}