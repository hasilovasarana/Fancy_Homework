using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fancy_backend.Models;

namespace fancy_backend.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        FancyEntities db = new FancyEntities();
     
        public ActionResult Index()
        {

            // Main Image    
            ViewBag.Image = db.Sliders.ToList();   
            
            // Feature Boxes
            ViewBag.featureBoxes = db.Feature_Boxes.ToList();

            // Feature
            var featureTitle = from fT in db.Features.ToList()
                          where fT.id==1
                          select fT.feature_title;
            var featureImage = from fI in db.Features.ToList()
                               where fI.id == 1
                               select fI.feature_img;
            var featureText = from ft in db.Features.ToList()
                               where ft.id == 1
                               select ft.feature_text;

            ViewBag.feature = db.Features.ToList();
            ViewBag.testimonials = db.Testimonials_Slider.ToList();
            var categories = db.Categories.ToList();
            ViewBag.contacts = db.Contacts.ToList();

            var serviceTitle = from s in db.Service_Area.ToList()
                               where s.service_id == 1
                               select s.service_title;
            var serviceSubtitle = from ss in db.Service_Area.ToList()
                                  where ss.service_id == 1
                                  select ss.service_subtitle;
            ViewBag.servicesTitle = serviceTitle.Take(1).ToList();
            ViewBag.servicesSubtitle = serviceSubtitle.Take(1).ToList();
            ViewBag.services = db.Service_Area.ToList();
            ViewBag.latest = db.Latest_News.ToList();
            return View(categories);
        }      
        
        
 
    }
}