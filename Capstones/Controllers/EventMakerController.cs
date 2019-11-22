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
            List<EventMaker> eventMakers = db.EventMakers.ToList();
            return View();
        }

        // GET: EventMaker/Details/5
        public ActionResult Details(int ID)
        {
            EventMaker eventMaker = db.EventMakers.Where(e => e.ID == ID).FirstOrDefault();
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
                db.EventMakers.Add(eventMaker);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EventMaker/Edit/5
        public ActionResult Edit(int ID)
        {
            EventMaker eventMaker = db.EventMakers.Where(c => c.ID == ID).FirstOrDefault();
            return View(eventMaker);
        }

        // POST: EventMaker/Edit/5
        [HttpPost]
        public ActionResult Edit(int ID, EventMaker eventMaker)
        {
            try { 
            eventMaker = db.EventMakers.Where(c => c.ID == ID).FirstOrDefault();

            return RedirectToAction("Index");
        }
           catch 
            {
                return View();
            }
}

        // GET: EventMaker/Delete/5
        public ActionResult Delete(int ID)
        {
            EventMaker eventMaker= db.EventMakers.Where(c => c.ID == ID).FirstOrDefault();
            return View(eventMaker);
        }

        // POST: EventMaker/Delete/5
        [HttpPost]
        public ActionResult Delete(int ID, EventMaker eventMaker)
        {
            try
            {
                // TODO: Add delete logic here
                eventMaker = db.EventMakers.Where(c => c.ID == ID).FirstOrDefault();
                db.EventMakers.Remove(eventMaker);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(ID);
            }
        }
    }
}
