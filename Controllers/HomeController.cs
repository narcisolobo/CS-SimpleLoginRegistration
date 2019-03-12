using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleLoginRegistration.Models;

namespace SimpleLoginRegistration.Controllers {
    public class HomeController : Controller {

        [HttpGet]
        [Route ("")]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost]
        [Route ("registration")]
        public IActionResult Registration (RegistrationModel newRegistration) {
            if (ModelState.IsValid) {
                return RedirectToAction ("Success");
            }
            return View ("Index");
        }

        [HttpPost]
        [Route ("login")]
        public IActionResult Login (LoginModel newLogin) {
            if (ModelState.IsValid) {
                return RedirectToAction ("Success");
            }
            return View ("Index");
        }

        [HttpGet]
        [Route ("success")]
        public IActionResult Success () {
            return View ("Success");
        }
    }
}