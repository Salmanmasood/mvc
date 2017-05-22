using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MvcApplication18.Models
{
    public class customEmailValidator:ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value==null)
            {
                return new ValidationResult("Email is required!");
            
            }

            else
            {
                if (Regex.IsMatch(value.ToString(), @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$",RegexOptions.IgnoreCase))
                {
                    return ValidationResult.Success;

                }

                else
                {
                    return new ValidationResult("Email is NOT In correct format!");
                }
            }

                //return base.IsValid(value, validationContext);
        }




    }
}