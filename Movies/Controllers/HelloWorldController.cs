using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1a.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public ActionResult Index() // ActionResult string
        {
            return View();
            // return "<h1>Hello world from Index action!</h1>";
        }

        public ActionResult Welcome(string name, int numTimes = 0) // string
        {
            ViewBag.name = name;
            ViewBag.numTimes = numTimes;
            return View();
            // return "<h1>Welcome!!!" + name + numTimes + "</h1>";
        }
	}
}