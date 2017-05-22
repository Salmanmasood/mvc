using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcApplication7.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            string[] names = new string[] { "asp classic", "asp.net", "ASP MVC" };
            ViewData["TECHNAME"] = names;

            ViewData["name"] = "salman masood";

            MvcApplication7.Models.student OB = new MvcApplication7.Models.student();
            OB.id = 1; OB.name = "SALMAN"; OB.salary = 243432423423;
            MvcApplication7.Models.student OB2 = new MvcApplication7.Models.student();
            OB2.id = 2; OB2.name = "SALMAN MASOOD"; OB2.salary = 95034534543;

            List<MvcApplication7.Models.student> LI = new List<MvcApplication7.Models.student>();
            LI.Add(OB);
            LI.Add(OB2);

            ViewData["DATA"] = LI;


           
            
            return View();
        }

    }
}
