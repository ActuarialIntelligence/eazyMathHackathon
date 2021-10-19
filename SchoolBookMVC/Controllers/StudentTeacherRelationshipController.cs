using Ninject;
using SchoolBook.DependencyResolution;
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
    public class StudentTeacherRelationshipController : Controller
    {
        // GET: StudentTeacherRelationship
        public ActionResult StudentTeacherRelationship()
        {
            var module = new BaseNinjectModule();
            var kernel = new StandardKernel(module);
            var reader = kernel.Get<IDataReader<IList<Student>>>("StudentsByPlaceReader");
            var results = reader.GetData(1);

            return View(new StudentTeacherRelationshipViewModel() { studentList= new List<Student>(), TutorID = 1});
        }
        [HttpPost]  
        public ActionResult StudentTeacherRelationship(StudentTeacherRelationshipViewModel model)
        {
            var module = new BaseNinjectModule();
            var kernel = new StandardKernel(module);
            var relationships = new List<StudentTeacherRelationship>();
            var studentsList = model.StudentIDs.Split('|');
            int cnt = 0;
            foreach(var student in studentsList)
            {
                if (cnt != 0)
                {
                    relationships.Add(new SchoolBook.Domain.StudentTeacher.StudentTeacherRelationship() { StudentID = int.Parse(student), TutorID = model.TutorID });                    
                }
                cnt++;
            }
            var writer = kernel.Get<IDataWriter<IList<StudentTeacherRelationship>>>();
            writer.WriteData(relationships);
            return View(model);
        }
    }
}