using Capstones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstones.Controllers
{
    public class EventMakerController : Controller
    {
        ApplicationDbContext db;
        public EventMakerController()
        {
            db = new ApplicationDbContext();
        }
        // GET: EventMaker
        public ActionResult Index()
        {
            return View();
        }

        // GET: EventMaker/Details/5
        public ActionResult Details(int ID)
        {
            EventMaker eventMaker = db.EventMaker.Where(c => c.ID == ID).FirstOrDefault();
            return View(eventMaker);
        }

        // GET: EventMaker/Create
        public ActionResult Create()
        {

            EventMaker eventMaker = new EventMaker();
            return View(eventMaker);
        }

        // POST: EventMaker/Create
        [HttpPost]
        public ActionResult Create(EventMaker eventMaker)
        {
            try
            {
                // TODO: Add insert logic here
                db.EventMaker.Add(eventMaker);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EventMaker/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventMaker/Edit/5
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

        // GET: EventMaker/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventMaker/Delete/5
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
