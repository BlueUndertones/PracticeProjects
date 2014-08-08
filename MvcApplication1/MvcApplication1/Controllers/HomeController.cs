using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = " ";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is edited.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact changed to me.";

            return View();
        }


        public ActionResult Person()
        {
            ViewBag.Message = "This is the person page.";

            return View();
        }

        public ActionResult Form()
        {
            ViewBag.Message = "Form to take information.";

            return View();
        }

        public ActionResult ThisIsForTesting()
        {
            ViewBag.Message = "Hidden tesing page.";

            return View();
        }

        [HttpPost]
        public ActionResult ThisIsForTesting(string firstname, string lastname, string email)
        {
            ViewData["firstname"] = firstname;
            ViewData["lastname"] = lastname;
            ViewData["email"] = email;

            return View();
        }
    }
}
