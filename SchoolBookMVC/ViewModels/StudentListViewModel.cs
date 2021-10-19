using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolBookMVC.ViewModels
{
    public class StudentListViewModel
    {
        public List<SchoolBook.Domain.StudentTeacher.Student> StudentList { get; set; }
        public string StudentsAssignedValue { get; set; }
        public List<SubSyllabusViewModel> SubSyllabus {get; set;}
        public string SelectedSubSyllabus { get; set; }
        public int NoOfQuestions { get; set; }
        public int SubSyllabusID { get; set; }
    }
}