using loaddatamvc.ModelClass;
using loaddatamvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loaddatamvc.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {


            employeeviewmodel emp = new employeeviewmodel();
            List<employees> li = emp.getallemployees();
            

            return View(li);
        } //method end............
        [HttpGet]
        public ActionResult create()
        {


            
            return View();
        } //method end............

        [HttpPost]
        public ActionResult create(employees emp)
        {
            if (ModelState.IsValid)
            {
                employeeviewmodel ob = new employeeviewmodel();
                ob.insert_loginmethod(emp);
               return RedirectToAction("Index");
    
            }
            
            return View();
        
        
        } //method end............



        public ActionResult details(int id)
        {

            employeeviewmodel ob = new employeeviewmodel();
            employees emp = ob.getallemployeesbyid(id);
            return View(emp);


        } //method end............


        public ActionResult update(int id)
        {

            employeeviewmodel ob = new employeeviewmodel();
            employees emp = ob.getallemployeesbyid(id);
            return View(emp);


        } //method end............


        [HttpPost]
        public ActionResult update(employees emp)
        {
            if (ModelState.IsValid)
            {
                employeeviewmodel ob = new employeeviewmodel();
                ob.update_loginmethod(emp);
                return RedirectToAction("Index");

            }

            return View();


        } //method end............


        public ActionResult delete(int id)
        {

            employeeviewmodel ob = new employeeviewmodel();
            employees emp = ob.getallemployeesbyid(id);
            return View(emp);


        } //method end............
              [HttpPost]
        public ActionResult delete(employees emp)
        {
            if (ModelState.IsValid)
            {
                employeeviewmodel ob = new employeeviewmodel();
                ob.delete_loginmethod(emp);
                return RedirectToAction("Index");

            }

            return View();


        } //method end............




    }
}
