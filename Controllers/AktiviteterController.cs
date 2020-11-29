using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MakersOfDenmark.Models;

namespace MakersOfDenmark.Controllers
{
    public class Aktiviteter : Controller
    {
        // 
        // GET: /Aktiviteter/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Aktiviteter/id/ 

        public IActionResult Id(int? id)
        {
            var aktivitet = new Aktivitet { Id = id.ToString(), Title = "Norwich Science Festival", Date = "27. november", StartTime = "kl. 16:00", MakerSpace = "FabLab UCL", Address = "Seebladsgade 1, 5000 Odense", ImgUrl = "/img/aktiviteter/1.jpg" };
            return View(aktivitet);
        }
    }
}