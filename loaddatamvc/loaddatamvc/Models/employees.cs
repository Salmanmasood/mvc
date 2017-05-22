using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace loaddatamvc.Models
{
    public class employees
    {
        [Display(Name="EmployeeId :")]
        public int  emp_id{ get; set; }

        [Required(ErrorMessage="Name is Required!")]
        [Display(Name = "Name:")]
        public string emp_name { get; set; }

        [Required(ErrorMessage = "Email is Required!")]
        [Display(Name = "Email :")]
        public string emp_email { get; set; }

    }
}