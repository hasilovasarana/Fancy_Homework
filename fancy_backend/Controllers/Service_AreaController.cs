using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fancy_backend.Models;

namespace fancy_backend.Controllers
{
    public class Service_AreaController : Controller
    {
        private FancyEntities db = new FancyEntities();

        // GET: Service_Area
        public ActionResult Index()
        {
            return View(db.Service_Area.ToList());
        }

        // GET: Service_Area/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service_Area service_Area = db.Service_Area.Find(id);
            if (service_Area == null)
            {
                return HttpNotFound();
            }
            return View(service_Area);
        }

        // GET: Service_Area/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Service_Area/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "service_id,service_title,service_subtitle,service_item_title,service_icon,service_item_subtitle")] Service_Area service_Area)
        {
            if (ModelState.IsValid)
            {
                db.Service_Area.Add(service_Area);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(service_Area);
        }

        // GET: Service_Area/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service_Area service_Area = db.Service_Area.Find(id);
            if (service_Area == null)
            {
                return HttpNotFound();
            }
            return View(service_Area);
        }

        // POST: Service_Area/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "service_id,service_title,service_subtitle,service_item_title,service_icon,service_item_subtitle")] Service_Area service_Area)
        {
            if (ModelState.IsValid)
            {
                db.Entry(service_Area).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(service_Area);
        }

        // GET: Service_Area/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service_Area service_Area = db.Service_Area.Find(id);
            if (service_Area == null)
            {
                return HttpNotFound();
            }
            return View(service_Area);
        }

        // POST: Service_Area/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Service_Area service_Area = db.Service_Area.Find(id);
            db.Service_Area.Remove(service_Area);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
