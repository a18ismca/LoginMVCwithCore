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
            ViewBag.LoginTable = loginConnection.GetAllUsers();
            return View();
        }
    }
}