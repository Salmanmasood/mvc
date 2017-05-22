using MvcApplication17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication17.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(employee emp)
        {
            return View();
        }

    }
}
