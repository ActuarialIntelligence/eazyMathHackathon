using SchoolBook.Domain.StudentTeacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolBookMVC.ViewModels
{
    public class StudentTeacherRelationshipViewModel
    {
        public int ID { get; set; }
        public int TutorID { get; set; }
        public int StudentID { get; set; }
        public string StudentIDs { get; set; }
        public IList<Student> studentList { get; set;}
    }
}