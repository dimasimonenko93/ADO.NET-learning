using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorWebApplication.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        [Route("myfirstroute")]
        public ActionResult helloworld()
        {
            return Content("Hello world");
        }
    }
}