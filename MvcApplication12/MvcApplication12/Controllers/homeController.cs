using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication12.Controllers
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
        public ActionResult Index(int firstnumber, int secnumber)
        {

            int r = firstnumber + secnumber;
            ViewBag.r = r;
            return View();
        }

    }
}
