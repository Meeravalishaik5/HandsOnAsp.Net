using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCModelValidations.Models;
using HandsOnMVCModelValidations.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnMVCModelValidations.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create() 
        {
            ViewBag.country = new SelectList(new string[] {"India", "UK", "USA", "Japan" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            UserRepository rep = new UserRepository();
            rep.Add(item);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string name,string pwd) 
        {
            UserRepository re = new UserRepository();
            User user = re.Validate(name,pwd);
            if (user != null) 
            {
                return RedirectToAction("Details",user);
            }
            else 
            {
                ViewData["err"] = "Invalid credintials";
                return View();
            }
        }
        public IActionResult Details([Bind(include:"Name")]User item) 
        {
            return View(item);
        }

    }
}