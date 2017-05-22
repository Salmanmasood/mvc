using MvcApplication21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication21.viewmodel
{
    public class employeeviewmodel
    {
        public List<employees> getallemp()
        {

            JIACADEMY ji = new JIACADEMY();
            return ji.employees.ToList();
        }

    }
}