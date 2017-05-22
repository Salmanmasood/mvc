using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication20.Models
{
    public class registeration
    {
        
        [Required(ErrorMessage="Name is required!!")]

        
        public string name { get; set; }

        [Required(ErrorMessage = "email is required!!")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage="Email not in format!")]
        public string email { get; set; }

        [Required(ErrorMessage = "phone# is required!!")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Message is required!!")]
        public string message { get; set; }

    
    }
}