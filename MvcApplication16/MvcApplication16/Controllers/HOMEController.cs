using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace MvcApplication16.Controllers
{
    public class HOMEController : Controller
    {
        //
        // GET: /HOME/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name, string email, string dob)
        {
            if (name.Length == 0)
            {

                ModelState.AddModelError("name", "Name is required");
                ViewBag.nameError = "*";
            }
            else
            {
                //^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$
                Regex r = new Regex(@"^[a-zA-Z''-'\s]{1,40}$");
            }

            if (email.Length == 0)
            {

                ModelState.AddModelError("email", "Email is required");
                ViewBag.emailError = "*";

            }

            else
            {
                
                Regex r = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
                if (!r.IsMatch(email))
                {

                    ModelState.AddModelError("email", "Email is not correct");
                    ViewBag.emailError = "*";

                }
            
            
            }
            if (dob.Length == 0)
            {

                ModelState.AddModelError("DOB", "Date Of Birth is required");
                ViewBag.dobError = "*"; 

            }
            else
            {

                DateTime temdate;
                
                bool isdateformat=DateTime.TryParse(dob,out temdate);
                if (isdateformat==false)
                {

                    ModelState.AddModelError("DOB", "Date Of Birth is not in correct format");
                    ViewBag.dobError = "*"; 

                }//if check end..............



            }


            if (ModelState.IsValid == true)
            {
                //database code.....................

                ViewBag.aletmessage = "<script> alert('changes are saved!!!');     </script>";

            }





            return View();
        }





    }
}
