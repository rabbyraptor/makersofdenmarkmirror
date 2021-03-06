﻿using System;
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
                new Blog() { Id = 1, Title = "Collapsible Dice Holder", Category = "3d print", Date = "30. oktober 2020", ImgUrl = "/img/blog/Dice-Tower.jpg"},
                new Blog() { Id = 2, Title = "Mid-Century Modern Moth Clock", Category = "Laser cutter", Date = "24. oktober 2020", ImgUrl = "/img/blog/IMG_8718.jpg"},
                new Blog() { Id = 3, Title = "Anti-Gravity Planter", Category = "3d print", Date = "29. september 2020", ImgUrl = "/img/blog/Anti-Gravity-Planter.jpg"},
                new Blog() { Id = 4, Title = "Quick Grab/Release Phone Stand", Category = "3d print", Date = "19. september 2020", ImgUrl = "/img/blog/Phone-Stand.jpg"},
                new Blog() { Id = 5, Title = "Illuminated Shadowbox Art", Category = "Laser cutter", Date = "10. september 2020", ImgUrl = "/img/blog/groovi-monster.jpg"},
                new Blog() { Id = 6, Title = "Brew Cart - Six Pack Beer Caddy", Category = "Cnc", Date = "9. september 2020", ImgUrl = "/img/blog/Prusa-Ratchets-1.jpg"},
                new Blog() { Id = 7, Title = "Decorative Wall Panels Mangroves of Plywood", Category = "Cnc", Date = "90. august 2020", ImgUrl = "/img/blog/turntable..jpg"},
                new Blog() { Id = 8, Title = "DaVinci Catapult Gift Card", Category = "3d print", Date = "19. august 2020", ImgUrl = "/img/blog/Cool-Things-Archery-Target-Pen-Holder.jpg"},
                new Blog() { Id = 9, Title = "Robisk dodekahedron evighedsspejl", Category = "3d print", Date = "12. august 2020", ImgUrl = "/img/blog/evighedsspejl.jpg"}
            };
            return View(blogs);
        }

        // GET: BlogController/Details/5
        public ActionResult Details(int id)
        {
            if (id == 1)
            {
                List<TopIndlæg> topindlægs = new List<TopIndlæg>();
                topindlægs.Add(new TopIndlæg { Id = 1, Title = "Collapsible Dice Holder", Category = "3d print", Date = "30. oktober 2020", ImgUrl = "/img/blog/Dice-Tower.jpg" });
                topindlægs.Add(new TopIndlæg { Id = 2, Title = "Mid-Century Modern Moth Clock", Category = "Laser cutter", Date = "24. oktober 2020", ImgUrl = "/img/blog/IMG_8718.jpg" });
                topindlægs.Add(new TopIndlæg { Id = 3, Title = "Anti-Gravity Planter", Category = "3d print", Date = "29. september 2020", ImgUrl = "/img/blog/Anti-Gravity-Planter.jpg" });

                BlogIndlæg blogind = new BlogIndlæg 
                { 
                    Title = "Collapsible Dice Holder", 
                    Date = "30. oktober 2020", 
                    Subheading = "Dice dice dice dice dice", 
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ImgUrl = "/img/blog/Dice-Tower.jpg"
                };

                DetailsBlog mymodel = new DetailsBlog();
                mymodel.BlogIndlæg = blogind;
                mymodel.TopIndlægs = topindlægs;
                return View(mymodel);
            }
            else if (id == 2)
            {
                List<TopIndlæg> topindlægs = new List<TopIndlæg>();
                topindlægs.Add(new TopIndlæg { Id = 1, Title = "Collapsible Dice Holder", Category = "3d print", Date = "30. oktober 2020", ImgUrl = "/img/blog/Dice-Tower.jpg" });
                topindlægs.Add(new TopIndlæg { Id = 2, Title = "Mid-Century Modern Moth Clock", Category = "Laser cutter", Date = "24. oktober 2020", ImgUrl = "/img/blog/IMG_8718.jpg" });
                topindlægs.Add(new TopIndlæg { Id = 3, Title = "Anti-Gravity Planter", Category = "3d print", Date = "29. september 2020", ImgUrl = "/img/blog/Anti-Gravity-Planter.jpg" });

                BlogIndlæg blogind = new BlogIndlæg
                {
                    Title = "Mid-Century Modern Moth Clock",
                    Date = "24. oktober 2020",
                    Subheading = "Is this even a modern moth clock?",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ImgUrl = "/img/blog/IMG_8718.jpg"
                };

                DetailsBlog mymodel = new DetailsBlog();
                mymodel.BlogIndlæg = blogind;
                mymodel.TopIndlægs = topindlægs;
                return View(mymodel);
            }
            else if (id == 3)
            {
                List<TopIndlæg> topindlægs = new List<TopIndlæg>();
                topindlægs.Add(new TopIndlæg { Id = 1, Title = "Collapsible Dice Holder", Category = "3d print", Date = "30. oktober 2020", ImgUrl = "/img/blog/Dice-Tower.jpg" });
                topindlægs.Add(new TopIndlæg { Id = 2, Title = "Mid-Century Modern Moth Clock", Category = "Laser cutter", Date = "24. oktober 2020", ImgUrl = "/img/blog/IMG_8718.jpg" });
                topindlægs.Add(new TopIndlæg { Id = 3, Title = "Anti-Gravity Planter", Category = "3d print", Date = "29. september 2020", ImgUrl = "/img/blog/Anti-Gravity-Planter.jpg" });

                BlogIndlæg blogind = new BlogIndlæg
                {
                    Title = "Anti-Gravity Planter",
                    Date = "29. september 2020",
                    Subheading = "Plants vs Zombies",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ImgUrl = "/img/blog/Anti-Gravity-Planter.jpg"
                };

                DetailsBlog mymodel = new DetailsBlog();
                mymodel.BlogIndlæg = blogind;
                mymodel.TopIndlægs = topindlægs;
                return View(mymodel);
            }
            return View();
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
