using SchoolBookMVC.GoogleAIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolBookMVC.ViewModels
{
    public class RegistrationViewModel
    {
        public string Name { get; set; }
        public string Displayname { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public int AreaCode { get; set; }
        public string SchoolCode { get; set; }
        public string ImageUrl { get; set; }
        public bool StudentOrNot { get; set; }

        public PlacesApiQueryResponse Choices { get; set; }
    }
}