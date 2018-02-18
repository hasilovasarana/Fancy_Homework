using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace fancy_backend.Controllers
{
    public class AdminController : Controller
    {
         // GET: Admin

        public ActionResult Index()
        {
           return View();
            
        }


        [HttpGet]
        public ActionResult LogIn()
        {
            return View();

        }

        [HttpPost]
        public ActionResult LogIn(string admin_email,string admin_password)
        {
            
            
            if (Check())
            {
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
       
        
         
           
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return View();
        }

        public ActionResult Cancel()
        {
            return RedirectToAction("Index","Admin");
        }
       
        public ActionResult  SessionCheck(FormCollection form)
        {
            Session["adminEmail"] =form["admin_email"] ;
            Session["adminPassword"] = form["admin_password"];
            
            return View();
        }
        public bool Check()
        {

            if (Session["admin_email"] != null)

            {
                ViewBag.Message = "Welcome" + Session["AdminEmail"];
                return true; 
            }
            else
            {
                return false;
            }
           
        }
      
    }
}
