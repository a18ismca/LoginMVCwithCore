using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginAppMVC.Models;

namespace LoginAppMVC.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login/LoginView
        public IActionResult LoginView()
        {
            var loginConnection = new LoginConnect();
            ViewBag.LoginTable = loginConnection.GetAllUsernames();

            return View();
        }
   
        public IActionResult Check()
        {
            var loginConnection = new LoginConnect();

            var storedUsernames = loginConnection.GetAllUsernames();
            var storedPasswords = loginConnection.GetAllPasswords();
            

            TempData["statement"] = "Baby button clicked.";

            
            return RedirectToAction("LoginView");
        }


    }
}