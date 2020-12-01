using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MakersOfDenmark.Models;

namespace MakersOfDenmark.Controllers
{
    public class Faq : Controller
    {
        // GET: /Faq/

       public IActionResult Index()
        {
           //var faq = new Faq { Id = "1", Title = "Norwich Science Festival", Date = "27. november", StartTime = "kl. 16:00", MakerSpace = "FabLab UCL", Address = "Seebladsgade 1, 5000 Odense", ImgUrl = "/img/aktiviteter/1.jpg" };
            //return View(aktivitet);
            return View();
    }
}
}