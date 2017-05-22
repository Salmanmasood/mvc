using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication13.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem {Text="Karachi" ,Value="Karachi", Selected=true});
            li.Add(new SelectListItem { Text = "Lahore", Value = "Lahore" });
            li.Add(new SelectListItem { Text = "Islamabad", Value = "Islamabad" });

            ViewBag.city = li;
            return View();
        }

    }
}
