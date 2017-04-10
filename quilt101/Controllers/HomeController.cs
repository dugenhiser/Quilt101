using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace quilt101.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "A Place for quilts";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Infomation will go here";

            return View();
        }

        public IActionResult Quilts()
        {
            ViewData["Message"] = "Contact Infomation will go here";

            return View();
        }

        public IActionResult Designs()
        {
            ViewData["Message"] = "Contact Infomation will go here";

            return View();
        }

        public IActionResult Cart()
        {
            ViewData["Message"] = "Contact Infomation will go here";

            return View();
        }

        public IActionResult Faberic()
        {

            return View("Faberic","_FullPageLayout.cshtml");
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
