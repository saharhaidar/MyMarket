using MyMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMarket.Controllers
{
    public class MarketController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        // GET: Market
        public ActionResult Index()
        {
            var myModel = context.Market.ToList();
            return View(myModel);
        }

        // GET: Market/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Market/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Market/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Market/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Market/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Market/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Market/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
