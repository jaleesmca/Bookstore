using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            // return View("../../TempView/IndexTemp");
            return View();
        }
        public ViewResult Aboutus()
        {
            return View();
        }
        public ActionResult Contactus()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}
