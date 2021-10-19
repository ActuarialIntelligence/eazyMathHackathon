using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolBookMVC.Controllers
{
    public class ParametersController : Controller
    {
        // GET: Parameters
        public ActionResult AddParameterValues()
        {
            return View();
        }
    }
}