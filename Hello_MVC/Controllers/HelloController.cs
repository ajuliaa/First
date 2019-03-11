using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello_MVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Anything()
        {
            return Content("Hello,world!");
        }
        public ActionResult Something()
        {
            return View();
        }
    }
}