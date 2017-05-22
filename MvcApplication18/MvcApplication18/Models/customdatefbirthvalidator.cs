using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication18.Models
{
    public class customdatefbirthvalidator : ValidationAttribute
    {


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value == null)
            {
                return new ValidationResult("Date Of Birth is required!");
            
            }

            else
            {
                DateTime tempdate;
                bool isdateformat = DateTime.TryParse(value.ToString(),out tempdate);
                if (isdateformat==true)
                {
                    return ValidationResult.Success;
    
                }
                else
                {
                    return new ValidationResult("Date Of Birth is not in correct format!!");
                }
            }
            //return base.IsValid(value, validationContext);
        }

    }
}