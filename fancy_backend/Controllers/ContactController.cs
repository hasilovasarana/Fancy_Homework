using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using fancy_backend.Models;

namespace fancy_backend.Controllers
{
    public class ContactController : Controller
    {
        FancyEntities db = new FancyEntities();
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.contacts = db.Contacts.ToList();
            var categories = db.Categories.ToList();
            return View(categories);
        }

      
    }
}