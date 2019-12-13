using Capstones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstones.Controllers
{
    
    public class EventsController : Controller
    {
        ApplicationDbContext db;
        public EventsController()
        {
            db = new ApplicationDbContext();

        }

        // GET: Events
        public ActionResult Index()
        {
            List<Events> events = db.Events.ToList();
            return View(events);
        }

        // GET: Events/Details/5
        public ActionResult Details(int Id)
        {
            Events Event = db.Events.Where(e => e.Id == Id).FirstOrDefault();
            return View(Event);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            Events Event = new Events();
        return View(Event); 
        }

        // POST: Events/Create
        [HttpPost]
        public ActionResult Create(Events Event)
        {
            try
            {
                // TODO: Add insert logic here
                db.Events.Add(Event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int Id)
        {
           Events Event= db.Events.Where(c => c.Id == Id).FirstOrDefault();
            return View(Event);
        }

        // POST: Events/Edit/5
        [HttpPost]
        public ActionResult Edit(int Id, Events Event)
        {
            try
            {
                // TODO: Add update logic here
                Events DbEvents = db.Events.Where(c => c.Id == Id).FirstOrDefault();
               
                DbEvents.DateTImeOfEvent = Event.DateTImeOfEvent;
                DbEvents.Attendees = Event.Attendees;
                db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Events/Delete/5
        public ActionResult Delete(int Id)
        {
            Events Event = db.Events.Where(e => e.Id == Id).FirstOrDefault();
            return View();
        }

        // POST: Events/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id, Events Event )
        {
            try
            {
                // TODO: Add delete logic here
                Event = db.Events.Where(c => c.Id == Id).FirstOrDefault();
                db.Events.Remove(Event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(Id);
            }
        }
    }
}
