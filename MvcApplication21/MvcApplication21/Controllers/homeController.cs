using MvcApplication21.Models;
using MvcApplication21.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication21.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {

            employeeviewmodel evm = new employeeviewmodel();
            List<employees> emp = evm.getallemp();
            return View(emp);
        }

    }
}
