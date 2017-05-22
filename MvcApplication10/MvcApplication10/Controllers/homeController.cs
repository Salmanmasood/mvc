using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication10.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
           TempData["data"] = "salman masood";
           TempData.Keep();
            return View();
        }

        public ActionResult Index2()
        {
            

            return View();
        }




    }
}
