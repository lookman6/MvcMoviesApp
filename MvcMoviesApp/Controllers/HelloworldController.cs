using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMoviesApp.Controllers
{
    public class HelloworldController : Controller
    {
        // GET: HelloworldController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloworldController/Welcome
        public string Welcome(string filiere, int level=3)
        {
            return "Bienvenue mon pote ! "+"Vous etes sur ma page et je suis etudiant en "+filiere+" en "+level+" annees !";
        }

        // GET: HelloworldController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HelloworldController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelloworldController/Create
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

        // GET: HelloworldController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloworldController/Edit/5
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

        // GET: HelloworldController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloworldController/Delete/5
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
