using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult home()
        {
            return View();
        }


        public ActionResult About()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }



    }
}
