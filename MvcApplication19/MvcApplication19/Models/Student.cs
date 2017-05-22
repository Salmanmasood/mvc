using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication19.Models
{
    public class Student
    {
        [Required(ErrorMessage="Name is Reuqired!!!!!")]
        public string name { get; set; }
    }
}