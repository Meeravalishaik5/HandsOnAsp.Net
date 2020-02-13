using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelValidations.Models;

namespace ModelValidations.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login item)
        {

            if (ModelState.IsValid) 
            {
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee item)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            else
                return View();
        }
    }
}