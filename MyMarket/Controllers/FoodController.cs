﻿using MyMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMarket.Controllers
{
    public class FoodController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        // GET: Food
        public ActionResult Index()
        {
            var myModel = context.Food.ToList();
            return View(myModel);
        }

        // GET: Food/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Food/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Food/Create
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

        // GET: Food/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Food/Edit/5
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

        // GET: Food/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Food/Delete/5
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
