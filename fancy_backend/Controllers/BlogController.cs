using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fancy_backend.Models;
namespace fancy_backend.Controllers
{
    public class BlogController : Controller
    {
        FancyEntities db = new FancyEntities();
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.contacts = db.Contacts.ToList();
            ViewBag.categories = db.Categories.ToList();
            ViewBag.blogs = db.Blogs.ToList();
            var testimonials = from t in db.Testimonials_Slider.ToList()
                               where t.testimonials_slider_id == 1
                               select t;
             ViewBag.testimonials = testimonials.Take(1).ToList();
            ViewBag.latest = db.Latest_News.ToList();
          
            var categories = db.Categories.ToList();
            return View(categories);
        }
    }
}