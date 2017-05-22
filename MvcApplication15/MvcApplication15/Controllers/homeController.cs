using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication15.Controllers
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
        public ActionResult Index(string name,string email,string dob)
        {
            if (name.Length==0)
            {

                ModelState.AddModelError("name", "Name is required");
                ViewBag.nameError = "*";
            }


            if (email.Length == 0)
            {

                ModelState.AddModelError("email", "Email is required");
            }

           if (dob.Length == 0)
            {

                ModelState.AddModelError("DOB", "Date Of Birth is required");
            }

           if (ModelState.IsValid==true)
           {
               //database code.....................

               ViewBag.aletmessage = "<script> alert('changes are saved!!!');     </script>";

           }





            return View();
        }


    }
}
