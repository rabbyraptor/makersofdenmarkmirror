using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using MakersOfDenmark.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MakersOfDenmark.Controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController
        public ActionResult Index()
        {
            /* API Connection. 

            //opret en web client
            WebClient wc = new WebClient();
            //hent data fra API (Kommer som json)
            var json = wc.DownloadString("https://localhost:44399/api/blog");
            //deserialisere det rå data til List<Student>
            var options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            var result = JsonSerializer.Deserialize<List<Blog>>(json, options);
            //Returnere
            return View(result);

            */

            /* En forloop med en liste af blogs
 
            List<Blog> blogs = new List<Blog>();
            // hent liste med studerende fra db
            // vi opretter mock data
            for (int i = 0; i < 10; i++)
            {
                Blog blog = new Blog
                {
                    Id = i,
                    Title = "Title1",
                    Category = "Category",
                    Date = 1 + i + ". " + "november"
                };
                blogs.Add(blog);
            }
            return View(blogs);
            */

            List<Blog> blogs = new List<Blog>
            {
                new Blog() { Id = 1, Title = "test", Category = "Laser", Date = "1. november"},
                new Blog() { Id = 2, Title = "test2", Category = "Laser", Date = "2. november"},
                new Blog() { Id = 3, Title = "test3", Category = "Laser", Date = "3. november"},
                new Blog() { Id = 4, Title = "test4", Category = "Laser", Date = "4. november"}
            };
            return View(blogs);
        }

        // GET: BlogController/Details/5
        public ActionResult Details(int id)
        {


            var blogs = new Blog() { Id = id, Title = "test", Category = "Laser", Date = "1. november" };
 
            return View(blogs);
        }

        // GET: BlogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
