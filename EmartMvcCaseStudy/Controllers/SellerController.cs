using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EmartMvcCaseStudy.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
namespace EmartMvcCaseStudy.Controllers
{
    public class SellerController : Controller
    {
        private readonly SellerContext _context;
        private readonly CategoryContext _categoryContext;
        private readonly SubCategoryContext _subCategoryContext;
        private readonly ItemsContext _itemsContext;
        private readonly IWebHostEnvironment hostingEnvironment;
        public SellerController(IWebHostEnvironment hostingEnvironment,SellerContext context1,CategoryContext categoryContext,SubCategoryContext subCategory,ItemsContext itemsContext)
        {
            this._context = context1;
            this._categoryContext = categoryContext;
            this._subCategoryContext = subCategory;
            this._itemsContext = itemsContext;
            this.hostingEnvironment = hostingEnvironment;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seller/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // POST: Seller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SellerViewmodel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.Photo != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    string[] name = model.Photo.FileName.Split('\\');
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + name[name.Length-1];
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                Seller se = new Seller
                {
                    SUSERNAME = model.SUSERNAME,
                    SPASSWORD = model.SPASSWORD,
                    SCOMPANYNAME = model.SCOMPANYNAME,
                    SGSTIN = model.SGSTIN,
                    SADDRESS = model.SADDRESS,
                    SWEBSITE=model.SWEBSITE, 
                    SMOBILENO=model.SMOBILENO,
                    SEMAILID=model.SEMAILID,
                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    PhotoPath = uniqueFileName
                };

                _context.Add(se);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = se.SID });
            }

            return View();

        }
        [HttpGet]
        public ActionResult Login() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Seller se) 
        {
            Seller loguser = _context.Sellers.FirstOrDefault(e => e.SUSERNAME == se.SUSERNAME && e.SPASSWORD == se.SPASSWORD);
            if (loguser == null)
            {
                ViewBag.msg = "Not Valid User";
                return View();
            }
            else
            {
                //HttpContext.Session.SetString("UName", uc.Username);
                //HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("SellerOP");
            }

        }
        public ActionResult SellerOP() 
        {
            return View();
        }
        [HttpGet]
        public ActionResult SOperations() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult SOperations(Category ce)
        {
            try
            {
                // TODO: Add insert logic here
                _categoryContext.Add(ce);
                _categoryContext.SaveChanges();
                ViewBag.msg = ce.CNAME + " Has Added Successfully";

                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.msg = ce.CNAME + " Has Failed To ADD";
                //return View();
            }
            return View();

        }
        [HttpGet]
        public ActionResult AddSubCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSubCategory(SubCategory ce)
        {
            try
            {
                // TODO: Add insert logic here
                _subCategoryContext.Add(ce);
                _subCategoryContext.SaveChanges();
                ViewBag.msg = ce.SNAME + " Has Added Successfully";

                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.msg = ce.SNAME + " Has Failed To ADD";
                //return View();
            }
            return View();

        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Items ce)
        {
            try
            {
                // TODO: Add insert logic here
                _itemsContext.Add(ce);
                _itemsContext.SaveChanges();
                ViewBag.msg = ce.INAME + " Has Added Successfully";

                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.msg = ce.INAME + " Has Failed To ADD";
                //return View();
            }
            return View();

        }

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
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

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
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