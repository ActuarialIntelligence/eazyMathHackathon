
using Ninject;
using SchoolBook.DependencyResolution;
using SchoolBook.Domain.HomeWork;
using SchoolBook.Domain.YouTube;
using SchoolBook.Infrastructure.Readers.Interfaces;
using SchoolBookMVC.Models;
using SchoolBookMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolBookMVC.Controllers
{
    public class PortalController : Controller
    {
        // GET: Portal
        public ActionResult StudentPortal()
        {

            var module = new BaseNinjectModule();
            var kernel = new StandardKernel(module);
            var readerHomework = kernel.Get<IReader<IList<YouTube>>>();
            var result = readerHomework.GetData();
            var viewModels = new List<YouTubeViewModel>();
            foreach(var value in result)
            {
                var model = new YouTubeViewModel();
                model.SubSyllabusID = value.SubSyllabusID;
                model.ImageLink = value.ImageLink;
                model.VideoLink = value.VideoLink;
               
                viewModels.Add(model);
            }
            var returnModel = new YouTubeWrapperViewModel();
            returnModel.YouTubeModels = viewModels;
            return View(returnModel);
        }

        public ActionResult ChartView() // No need for a model entry. 
        {

            var module = new BaseNinjectModule();
            var kernel = new StandardKernel(module);
            var readerHomework = kernel.Get<IDataReader<SubSyllabusByPercentage>>();
            var result = readerHomework.GetData(1);// Get the student ID from the cookie entry.
            var model = new PercentageViewModel();
            model.SubSyllabusName = result.SubSyllabusName;
            model.Average = result.Average;
            return View(model);
        }
    }
}