using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Umg.Web.Controllers
{
    public class DetalleVenta_Controller : Controller
    {
        // GET: DetalleVenta_Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: DetalleVenta_Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DetalleVenta_Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetalleVenta_Controller/Create
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

        // GET: DetalleVenta_Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DetalleVenta_Controller/Edit/5
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

        // GET: DetalleVenta_Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DetalleVenta_Controller/Delete/5
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
