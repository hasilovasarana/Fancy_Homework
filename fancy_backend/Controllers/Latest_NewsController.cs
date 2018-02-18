using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fancy_backend.Models;
using System.IO;

namespace fancy_backend.Controllers
{
    public class Latest_NewsController : Controller
    {
        private FancyEntities db = new FancyEntities();

        // GET: Latest_News
        public ActionResult Index()
        {
            return View(db.Latest_News.ToList());
        }

        // GET: Latest_News/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Latest_News latest_News = db.Latest_News.Find(id);
            if (latest_News == null)
            {
                return HttpNotFound();
            }
            return View(latest_News);
        }

        // GET: Latest_News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Latest_News/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,latest_news_title,latest_news_subtitle,latest_news_item_title,latest_news_item_subtitle")] HttpPostedFileBase latest_news_img, Latest_News latest_News)
        {
            if (ModelState.IsValid)
            {
                var file_name = Path.GetFileName(latest_news_img.FileName);
                if (latest_news_img.ContentLength>0)
                {
                    var file_path = Path.Combine(Server.MapPath("/LatestUpload"), file_name);
                    latest_news_img.SaveAs(file_path);
                }
                latest_News.latest_news_img = file_name;
                db.Latest_News.Add(latest_News);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(latest_News);
        }

        // GET: Latest_News/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Latest_News latest_News = db.Latest_News.Find(id);
            if (latest_News == null)
            {
                return HttpNotFound();
            }
            return View(latest_News);
        }

        // POST: Latest_News/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,latest_news_title,latest_news_subtitle,latest_news_item_title,latest_news_item_subtitle")] HttpPostedFileBase latest_news_img, Latest_News latest_News)
        {
            if (ModelState.IsValid)
            {
                db.Entry(latest_News).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(latest_News);
        }

        // GET: Latest_News/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Latest_News latest_News = db.Latest_News.Find(id);
            if (latest_News == null)
            {
                return HttpNotFound();
            }
            return View(latest_News);
        }

        // POST: Latest_News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Latest_News latest_News = db.Latest_News.Find(id);
            db.Latest_News.Remove(latest_News);
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
