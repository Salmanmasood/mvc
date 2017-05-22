using MvcApplication8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication8.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            blog []b = new blog[3];
            b[0] = new blog();
            b[1] = new blog();
            b[2] = new blog();

            b[0].name = "Google";
            b[0].link = "http://www.google.com.pk";
            b[1].name = "YAHOO!";
            b[1].link = "http://www.yahoo.com";
            b[2].name = "Gmail";
            b[2].link = "http://www.gmail.com";

            List<blog> li = new List<blog>();
            for (int i = 0; i < b.Length; i++)
            {
                li.Add(b[i]);
            }








            return View(li);
        }

    }
}
