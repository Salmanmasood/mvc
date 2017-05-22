using MvcApplication14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication14.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(maths ma)
        {
            int first = ma.x;
            int sec = ma.y;
            int r = first + sec;
            ViewBag.result = r;
            return View();
        }



    }
}
