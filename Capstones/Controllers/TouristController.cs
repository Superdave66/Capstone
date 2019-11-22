using Capstones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstones.Controllers
{
    public class TouristController : Controller
    {

        ApplicationDbContext db;

        public TouristController()
        {
            db = new ApplicationDbContext();
    }
            // GET: Tourist
            public ActionResult Index()
        {
            List<Tourist> Tourists = db.Tourists.ToList();
            return View();
        }

        // GET: Tourist/Details/5
        public ActionResult Details(int ID)
        {
            Tourist tourist = db.Tourists.Where(e => e.ID == ID).FirstOrDefault();
            return View(tourist);
        }

        // GET: Tourist/Create
        public ActionResult Create()
        {
            Tourist tourist = new Tourist();
            return View(tourist);
        }

        // POST: Tourist/Create
        [HttpPost]
        public ActionResult Create(Tourist tourist)
        {
            try
            {
                db.Tourists.Add(tourist);
                db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tourist/Edit/5
        public ActionResult Edit(int ID)
        {
            Tourist tourist = db.Tourists.Where(c => c.ID == ID).FirstOrDefault();
            return View(tourist);
        }

        // POST: Tourist/Edit/5
        [HttpPost]
        public ActionResult Edit(int ID, Tourist tourist)
        {
            try
            {
                Tourist DBtourist = db.Tourists.Where(c => c.ID == ID).FirstOrDefault();
                DBtourist.SelectedCity = tourist.SelectedCity;
                DBtourist.Interests = tourist.Interests;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tourist/Delete/5
        public ActionResult Delete(int ID)
        {

            Tourist tourist = db.Tourists.Where(c => c.ID == ID).FirstOrDefault();
            return View(tourist);
        }

        // POST: Tourist/Delete/5
        [HttpPost]
        public ActionResult Delete(int ID, Tourist tourist)
        {
            try
            {
                // TODO: Add delete logic here
                tourist = db.Tourists.Where(c => c.ID == ID).FirstOrDefault();
                db.Tourists.Remove(tourist);
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
