using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication5.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            string[] s = new string[4] { "asp.net", "php", "Ruby", "Pearl" };
            return View(s);
        }

    }
}
