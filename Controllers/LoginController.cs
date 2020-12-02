using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakersOfDenmark.Controllers
{
    public class LoginController : Controller
    {
        // GET: KontrolpanelController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KontrolpanelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KontrolpanelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KontrolpanelController/Create
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

        // GET: KontrolpanelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KontrolpanelController/Edit/5
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

        // GET: KontrolpanelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KontrolpanelController/Delete/5
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
