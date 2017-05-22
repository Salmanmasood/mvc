using MvcApplication18.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication18.Controllers
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

            if (ModelState.IsValid==true)
            {
                ViewBag.AlertMessage="<script>  alert('Data Saved Successfully!!!!'); </script>";   
            }
            return View();
        }
    }
}
