using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab19.Models;

namespace Lab19.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View(new User() { });
        }
        [HttpPost]
        public IActionResult Registration(User newUser)
        {
            if(!ModelState.IsValid)
            {
                return View( newUser);
            }
            else
            {
                return View("AddNewUser",newUser);
            }
        }
        public IActionResult AddNewUser(User user)
        {
            return View(user);
        }
        public IActionResult UserInfo(User user)
        {
            return View(user);
        }
    }
}
