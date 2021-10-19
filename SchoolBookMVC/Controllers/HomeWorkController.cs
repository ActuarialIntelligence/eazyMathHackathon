using System.Web.Mvc;
using SchoolBook.Logic;
using SchoolBookMVC.Models;
using System.Collections.Generic;
using Ninject.Modules;
using Ninject;
using SchoolBook.DependencyResolution;
using SchoolBook.Logic.Interfaces;
using AutoMapper;
using SchoolBookMVC.ViewModels;
using SchoolBook.Domain;
using SchoolBook.Infrastructure.Readers.Interfaces;
using SchoolBook.Domain.HomeWork;
using SchoolBook.Domain.MyOwnTimerBecauseDotNetsCrappyTimerWontWork;
using SchoolBook.Infrastructure.Writers.Interfaces;
using SchoolBook.Infrastructure.Data.Dto;
using System;

namespace SchoolBookMVC.Controllers
{
    public class HomeWorkController : Controller
    {
        // GET: HomeWork
        private static IList<string> questions;
        private static IList<string> answers;
        private int homeworkID;
        public ActionResult HomeWork()
        {
            
            var module = new BaseNinjectModule();
            var kernel = new StandardKernel(module);
            var readerHomework = kernel.Get<IDataReader<HomeWorkAssign>>();
            var pairingReader = kernel.Get<IDataReader<int>>();
            var homeWorkId = pairingReader.GetData(4); //Enter studentID 
            var allQuestions = "";
            var allAnswers = "";

            var homeWorkDetails = readerHomework.GetData(homeWorkId); // Enter homeWorkId
            homeworkID = homeWorkDetails.HomeMorkID;
            questions = new List<string>();
            answers = new List<string>();
            var parameter = new HomeworkParameters();
            var noOfQuestions = homeWorkDetails.NoOfQuestions;
            parameter.ComplexityID = 3;

            for (int i = 0; i < noOfQuestions; i++)
            {
                var function = Gr12Wrapper.GetSubSyllabusQuestionGenerator(5); //(int)homeWorkDetails.SubSyllabusID
                var temp = function.Invoke(parameter);
                allQuestions += temp.Split('$')[0] + "$";
                allAnswers += temp.Split('$')[1] + "$";
                questions.Add(temp.Split('$')[0]);
                answers.Add(temp.Split('$')[1]);
                function = null;
                MyTimer.IntervalTimer_Elapsed(0.2m);
            }

            var viewModel = new QuestionsViewModel();
            viewModel.questions = questions;
            viewModel.answers = new List<string>();
            viewModel.preview = true;
            var writer = kernel.Get<IDataWriter<SchoolBook.Domain.HomeWork.HomeWork>>("HomeworkQuestionsWriter");
            var hwDto = new SchoolBook.Domain.HomeWork.HomeWork();
            hwDto.SubSyllabusID = (int)homeWorkDetails.SubSyllabusID;
            hwDto.HomeWorkID = homeworkID;
            hwDto.Questions = allQuestions;
            hwDto.Answers = allAnswers;
            writer.WriteData(hwDto);
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult HomeWorkSubmitted(QuestionsViewModel model)
        {
            if (!model.preview)
            {
                var viewModel = new QuestionsViewModel();
                viewModel.questions = model.questions;
                viewModel.answers = model.answers;
                viewModel.HomeWorkID = model.HomeWorkID;
                return View("HomeWorkPreview", viewModel);
            }
            else
            {

                var answers = model.answers;
                var answersString = "";
                var module = new BaseNinjectModule();
                var kernel = new StandardKernel(module);
                var writer = kernel.Get<IWriter<string>>();
                foreach (var answer in answers)
                {
                    answersString += answer + "$";
                }
                writer.WriteData(answersString, model.HomeWorkID);
                return View();
            }
        }


    }
}