using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication17.Models
{
    public class employee
    {

        public int empid { get; set; }

        [Required(ErrorMessage="Name is Required")]
        [StringLength(25,ErrorMessage="Name cannot be greater than 25 characters")]
        public string name { get; set; }

        [Required(ErrorMessage = "email is Required")]

        [RegularExpression(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")]
        public string email { get; set; }

        [Required(ErrorMessage = "Age is Required")]
        [Range(18,60,ErrorMessage="Age should be b/w 18 and 60")]
        public int   age{ get; set; }

        public DateTime date { get; set; }
    
    }
}