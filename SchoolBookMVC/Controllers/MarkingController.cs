using Ninject;
using SchoolBook.DependencyResolution;
using SchoolBook.Infrastructure.Readers.Interfaces;
using SchoolBook.Infrastructure.Writers.Interfaces;
using SchoolBookMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolBookMVC.Controllers
{
    public class MarkingController : Controller
    {
        // GET: Marking
        public ActionResult Marking()
        {

            var module = new BaseNinjectModule();
            var kernel = new StandardKernel(module);
            var reader = kernel.Get<IDateGradeParametricDataReader<IList<SchoolBook.Domain.HomeWork.HomeWork>>>();
            var grade = 13;
            var date = DateTime.Now.AddDays(-2);
            var result = reader.GetData(date, grade);
            var viewModel = new List<MarkingViewModel>();
            foreach (var hw in result)
            {
                var vm = new MarkingViewModel();
                vm.HomeWorkID = hw.HomeWorkID;
                vm.Answers = hw.Answers.Split('$').ToList();
                vm.StudentAnswers = hw.StudentAnswers.Split('$').ToList();
                viewModel.Add(vm);
            }

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Marking(IList<MarkingViewModel> model)
        {

            var module = new BaseNinjectModule();
            var kernel = new StandardKernel(module);
            var writer = kernel.Get<IDataWriter<SchoolBook.Domain.HomeWork.HomeWork>>("MarksUpdater");
            var correctPercentage = 0m;

            foreach(var hw in model)
            {
                var noOfQuestions = 0;
                var correct = 0;
                var dto = new SchoolBook.Domain.HomeWork.HomeWork();
                dto.HomeWorkID = hw.HomeWorkID;
                foreach (var tick in hw.TicksAndCrosses)
                {
                    if(tick.Correct)
                    {
                        correct++;
                    }
                    noOfQuestions++;
                }
                correctPercentage = (decimal)correct / (decimal)noOfQuestions;
                dto.Percentage_Correct = correctPercentage;
                writer.WriteData(dto);
            }
            return View();
        }
    }
}