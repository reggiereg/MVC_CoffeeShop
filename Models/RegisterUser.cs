using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CoffeShopMVC.Models
{
    //Class for creating Users
    public class RegisterUser
    {
        //property and property validation for UserName
        [Required(ErrorMessage = "This field must have a value")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Your name must be between 4 and 30 characters")]
        public string UserName { get; set; }

        //property and property validation for Email
        [Required(ErrorMessage = "This field must have a value")]
        [RegularExpression(@"([A-Za-z]|[0-9]){5,30}(['@'])([A-Za-z]|[0-9]){5,10}(['.'])([A-Za-z]){1,3}", ErrorMessage = "Invalid Email entered")]
        public string Email { get; set; }

        //property and property validation for Password
        [Required(ErrorMessage = "This field must have a value")]
        [RegularExpression(@"([a-zA-Z]){1}[0-9a-zA-Z]{7,}", ErrorMessage = "Password must start with a letter and be at least 8 characters long")]
        public string Password { get; set; }

    }
}
