using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Domain.StudentTeacher
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Displayname { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public int AreaCode { get; set; }
        public int SchoolCode { get; set; }
        public string PlaceKey { get; set; }
    }
}
