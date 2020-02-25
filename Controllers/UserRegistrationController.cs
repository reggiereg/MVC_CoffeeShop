using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeShopMVC.Models;

namespace CoffeShopMVC.Controllers
{
    public class UserRegistrationController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        //Get the form
        [HttpGet]
        public IActionResult RegistrationForm()
        {
            //returns RegistrationForm view
            return View();
        }

        //Post the forms information to thee browser
        [HttpPost]
        public IActionResult WelcomePage(RegisterUser newUser)
        {
            //checks if data entered fits the model
            if (ModelState.IsValid)
            {
                //returns the WelcomePage if the user input fits the form
                return View("WelcomePage", newUser);
            }
            else
            {
                //returns the RegistrationForm again if user input doesn't fit the model
                return View("RegistrationForm");
            }
        }


    }
}