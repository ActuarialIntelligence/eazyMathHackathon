using SchoolBook.Domain.StudentTeacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolBookMVC.ViewModels
{
    public class ParameterHomeworkPairingViewModel
    {
        public int PairingID { get; set; }
        public int ParametersID { get; set; }
        public int HomeWorkID { get; set; }
        public int StudentIDs { get; set; }

        public IList<Student> studentList { get; set; }
    }
}