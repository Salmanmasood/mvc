using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication6.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            ViewBag.name = "salman masood";
            ViewBag.salary = 500000;
            string[] n = new string[4]{"asp","php","java","ruuby"};
            ViewBag.tech = n;

            MvcApplication6.Models.student ob = new MvcApplication6.Models.student();
            MvcApplication6.Models.student ob2 = new MvcApplication6.Models.student();

            ob.id = 1;
            ob.name = "salman";
            ob.salary = 200000;
            
           ViewBag.salman = ob;

            ob2.id = 2;
            ob2.name = "raza";
            ob2.salary = 220000;

            List<MvcApplication6.Models.student> li = new List<MvcApplication6.Models.student>();

            li.Add(ob);
            li.Add(ob2);

            ViewBag.lists = li;



            return View();
        }

    }
}
