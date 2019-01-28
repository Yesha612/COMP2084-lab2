using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
           
           
            return View();

        }

       public ActionResult Details(string Categories)
        {
            ViewBag.Categories = "You selected category:" + Categories;
            return View();
        }
    }
}