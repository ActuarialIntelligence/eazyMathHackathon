using Ninject;
using SchoolBook.DependencyResolution;
using SchoolBook.Domain;
using SchoolBook.Domain.HomeWork;
using SchoolBook.Domain.StudentTeacher;
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
    public class TutorController : Controller
    {
        // GET: Tutor
        public ActionResult TutorPortal()
        {
            var module = new BaseNinjectModule();
            var kernel = new StandardKernel(module);
            var reader = kernel.Get<IDataReader<IList<Student>>>("StudentsByTutorIDReader");
            var subSyllabusReader = kernel.Get<IDataReader<IList<SubSyllabus>>>();
            var subSyllabu = subSyllabusReader.GetData(13);
            var students = reader.GetData(1);
            var vmList = new List<SubSyllabusViewModel>();
            foreach(var item in subSyllabu)
            {
                var vm = new SubSyllabusViewModel();
                vm.Name = item.Name;
                vm.SubSyllabusID = item.SubSyllabusID;
                vm.SyllabusID = item.SyllabusID;
                vmList.Add(vm);
            }

            var studentList = new StudentListViewModel();
            var studentLs = new List<Student>();
            foreach (var student in students)
            {
                studentLs.Add(new Student() { ID = student.ID, Name = student.Name, ImgUrl = student.ImgUrl });
            } 
            studentList.StudentList = studentLs;
            studentList.SubSyllabus = vmList;
            return View(studentList);
        }
        [HttpPost]
        public ActionResult TutorPortal(StudentListViewModel model)
        {
            var domainHwAssign = new HomeWorkAssign(0, int.Parse(model.SelectedSubSyllabus), model.NoOfQuestions, DateTime.UtcNow);
            var module = new BaseNinjectModule();
            var kernel = new StandardKernel(module);
            var writer = kernel.Get<IDataWriter<HomeWorkAssign>>();
            writer.WriteData(domainHwAssign);

            //Written


            var reader = kernel.Get<IDataReader<IList<Student>>>("StudentsByTutorIDReader");
            var subSyllabusReader = kernel.Get<IDataReader<IList<SubSyllabus>>>();
            var subSyllabu = subSyllabusReader.GetData(13);
            var students = reader.GetData(1);
            var vmList = new List<SubSyllabusViewModel>();
            foreach (var item in subSyllabu)
            {
                var vm = new SubSyllabusViewModel();
                vm.Name = item.Name;
                vm.SubSyllabusID = item.SubSyllabusID;
                vm.SyllabusID = item.SyllabusID;
                vmList.Add(vm);
            }

            var studentList = new StudentListViewModel();
            var studentLs = new List<Student>();
            foreach (var student in students)
            {
                studentLs.Add(new Student() { ID = student.ID, Name = student.Name, ImgUrl = student.ImgUrl });
            }
            studentList.StudentList = studentLs;
            studentList.SubSyllabus = vmList;

            return View(studentList);
        }
    }
}