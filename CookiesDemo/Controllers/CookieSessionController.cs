using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CookiesDemo.Models;

namespace CookiesDemo.Controllers
{
    public class CookieSessionController : Controller
    {
        public readonly UserAccountContext _context;
        public CookieSessionController(UserAccountContext context)
        {
            this._context = context;
        }
        // GET: KeySession
        [Route("")]
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserAccount uc)
        {
            try
            {
                _context.Add(uc);
                _context.SaveChanges();
                ViewBag.message = uc.Username + " has got Succesfully Registered";
            }
            catch(Exception e) 
            {
                ViewBag.message = uc.Username + " Registration Failed..";
            }
            return View();
        }
        // GET: KeySession/Details/5
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserAccount uc)
        {
            UserAccount loguser = _context.UserAccounts.FirstOrDefault(e =>e.Username == uc.Username && e.Password==uc.Password);
            if (loguser == null)
            {
                ViewBag.msg = "Not Valid User";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("UName", uc.Username);
                //HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashBoard");
            }
        }
        public IActionResult CreateDashBoard() 
        {
            if (HttpContext.Session.GetString("UName") != null)
            {
                ViewBag.uname = HttpContext.Session.GetString("UName").ToString();
                //ViewBag.lldt = HttpContext.Session.GetString("lastLogin").ToString();
                if (Request.Cookies["lastLogin"]!=null) 
                {
                    ViewBag.lldt = Request.Cookies["lastLogin"].ToString();
                }
            }
            return View();
        }
        public ActionResult Logout() 
        {
            Response.Cookies.Append("lastLogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public ActionResult Index() 
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KeySession/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KeySession/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KeySession/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KeySession/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KeySession/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KeySession/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}