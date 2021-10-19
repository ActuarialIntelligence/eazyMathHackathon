using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolBookMVC.ViewModels
{
    public class MarkingViewModel
    {
        public int HomeWorkID { get; set; }
        public IList<TickObject> TicksAndCrosses {get; set;}
        public IList<string> Answers { get; set; }
        public IList<string> StudentAnswers { get; set; }
    }
}