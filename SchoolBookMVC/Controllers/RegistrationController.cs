using Ninject;
using SchoolBook.DependencyResolution;
using SchoolBook.Domain.StudentTeacher;
using SchoolBook.Infrastructure.Writers.Interfaces;
using SchoolBookMVC.GoogleAIP;
using SchoolBookMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolBookMVC.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Registration()
        {
            var viewModel = new RegistrationViewModel();
            var locations = API.GetPlaces(new Location() { lat = -26.19109 ,lng= 28.03469 });
            viewModel.Choices = locations;
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Registration(RegistrationViewModel model)
        {

            var module = new BaseNinjectModule();
            var kernel = new StandardKernel(module);
            var studentWriter = kernel.Get<IDataWriter<Student>>();
            var tutorWriter = kernel.Get<IDataWriter<Tutor>>();
            if (!model.StudentOrNot)
            {
                var stnt = new Student();
                stnt.Name = model.Name;
                stnt.ImgUrl = model.ImageUrl;
                stnt.PlaceKey = model.SchoolCode;
                studentWriter.WriteData(stnt);
            }
            else
            {
                var tut = new Tutor();
                tut.Name = model.Name;
                tut.ImgUrl = model.ImageUrl;
                tutorWriter.WriteData(tut);
            }
            return View(model);
        }
    }
}