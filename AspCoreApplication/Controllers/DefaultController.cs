using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspCoreApplication.Models;
namespace AspCoreApplication.Controllers
{
    public class DefaultController : Controller
    {
        private readonly EmployeeManagement emprepository;//=new EmployeeRepository();
        public DefaultController(EmployeeManagement emRepos) 
        {
            emprepository = emRepos;

        }
        public IActionResult Search(int? id) 
        {
            int ID = (int)((id == null) ? 1 : id);
            Employee em= emprepository.GetEmployee(ID);
            //  return "fdsf";
            //if (em != null)
            //{
            //    return Content(em.id + " " + em.name + " " + em.Dept);
            //}
            //return Content("Employee Id doesn't exist");
            //ViewData["id"] = em.id;
            //ViewData["name"] = em.name;
            //ViewData["dept"] = em.Dept;
            //ViewBag.id = em.id;
            //ViewBag.name = em.name;
            //ViewBag.dept = em.Dept;
            //ViewData["employee"] = em;
           // ViewBag.employee = em;
            return View(em);
        }
        public IActionResult Index()
        {
            List<Employee> el = emprepository.DisplayDetails();
            return View(el);
        }
        public ViewResult AboutEmployee() 
        {
            Employee el1 = emprepository.GetEmployee(2);
            // ViewBag.ProjName = "C#";
            EmployeeProjectView ep = new EmployeeProjectView();
            ep.employee1 = el1;
            ep.projectName = "C#";
            return View(ep);
        }
        public IActionResult GetAllEmployees() 
        {
            List<Employee> el = (emprepository.DisplayDetails()).Where(e=>e.Dept==Dept.IT).ToList();
            return View("Index", el);
        }
        [HttpGet]
        public IActionResult Create() 
        {
            //Employee el1 = emprepository.GetEmployee(2);
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee em)
        {
            //Employee el1 = emprepository.GetEmployee(2);
            // if (ModelState.IsValid) 
            //{
           // EmployeeRepository emd = new EmployeeRepository();
            emprepository.AddEmployee(em);
            return RedirectToAction("Index");
            //}
            //else
            //  return View("Fail");
            //return View();
        }
        public IActionResult Fail()
        {
            return View();
        }
        public IActionResult Success() 
        {
            return View();
        }
        public IActionResult List()
        {
            List<Employee> elist = emprepository.DisplayDetails();
            return View(elist);
        }
        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee employ3)
        {
            emprepository.AddEmployee(employ3);
            return RedirectToAction("Index");
        }
        public bool IsExist(string email) 
        {
            var res = (emprepository.DisplayDetails()).Find(e=>e.Email == email);
            if (res == null)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        [AcceptVerbs("Get","Post")]
        public JsonResult IsEmailExist(string email) 
        {
            return IsExist(email) ? Json(true) : Json("Email exist");
        }
        public IActionResult _myPartial() 
        {
            return View();
        }
    }
}