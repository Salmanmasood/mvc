using MvcApplication19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication19.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/
        [HttpGet]
        public ActionResult Index()
        {
            

            HttpCookie cookie = Response.Cookies["name"];
            
            if (cookie!=null)
            {
                string name = Response.Cookies["name"].Value;
                ViewData["name"] = name;
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(Student s)
        {
            
            if (ModelState.IsValid)
            {
                HttpCookie cookie = new HttpCookie("name");
                cookie.Value= s.name;

                HttpContext.Response.Cookies.Add(cookie);

            }
            return RedirectToAction("Index");
         
        }

    }
}
