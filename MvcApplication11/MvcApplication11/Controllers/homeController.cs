using MvcApplication11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication11.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            employess emp = new employess();
            emp.id = 0;
            emp.name = "salman";
            emp.salary = 3254543;
            employess emp2 = new employess();
            emp2.id = 0;
            emp2.name = "salman";
            emp2.salary = 1254543;

            List<employess> li = new List<employess>();
            li.Add(emp);
            li.Add(emp2);


            return View(li);
        }

        public ActionResult Index2()
        {
            return View();
        }

    }
}
