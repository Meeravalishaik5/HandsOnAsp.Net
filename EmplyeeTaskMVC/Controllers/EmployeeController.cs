using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmplyeeTaskMVC.Models;
using EmplyeeTaskMVC.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmplyeeTaskMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.designation = new SelectList(new string[] { "Analyst", "Reasercher", "Tester", "Developer" });
            ViewBag.proj= new SelectList(new string[] { "JAVA", "MVC", "C#", "ASP.NET" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee item)
        {
            EmployeeRepoistory rep = new EmployeeRepoistory();
            rep.Add(item);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(int uid, string pwd)
        {
            EmployeeRepoistory re = new EmployeeRepoistory();
            Employee user = re.Validate(uid, pwd);
            if (user != null)
            {
                return RedirectToAction("Details", user);
            }
            else
            {
                ViewData["err"] = "Invalid credintials";
                return View();
            }
        }
        public IActionResult Details(Employee item)
        {
            return View(item);
        }
    }
}