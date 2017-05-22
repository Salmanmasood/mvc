using MvcApplication9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication9.Controllers
{
    public class homeController : Controller
    {
       

        public ActionResult Index()
        {
            employees ex = new employees();
            ex.id = 1;
            ex.name = "salman";
            ex.salary = 23232432;
            employees ex2 = new employees();
            ex2.id = 2;
            ex2.name = "raza";
            ex2.salary = 4332432;

            List<employees> li = new List<employees>();
            li.Add(ex);
            li.Add(ex2);

            TempData["data"] = li;


            return View();
        }

    }
}
