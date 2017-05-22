using MvcApplication20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MvcApplication20.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult registrationpage()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult registrationpage(registeration reg)
        {
            if (ModelState.IsValid)
            {
                WebMail.Send(" ",reg.name+" is coming",
                    reg.message,
                    reg.phone,
                    reg.email, null, true, null, null, null, null, null,reg.email
                    
                                       
                    );

                return RedirectToAction("thankyou");


            }
            return View();
        }


        public ActionResult thankyou()
        {
            return View();
        }


    }
}
