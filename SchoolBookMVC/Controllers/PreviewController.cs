using AutoMapper;
using SchoolBookMVC.Models;
using SchoolBookMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolBookMVC.Controllers
{
    public class PreviewController : Controller
    {
        // GET: Preview
        public ActionResult Preview(string text)
        {
            // \[∫_\Δd\bo ω=∫_{∂\Δ}\bo ω\]
            var model = new PreviewViewModel();
            model.text = text;//@"\[∫_\Δd\bo ω=∫_{∂\Δ}\bo ω\]";
            //var viewModel = Mapper.Map<PreviewViewModel>(model);
            return View(model);
        }
    }
}