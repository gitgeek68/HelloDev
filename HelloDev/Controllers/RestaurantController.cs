using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloDev.Models;

namespace HelloDev.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        public ActionResult Create(Restaurant _resto)
        {
            return View(); 
        }

        public ActionResult Edit(Restaurant _resto)
        {
            return View();
        }
    }
}