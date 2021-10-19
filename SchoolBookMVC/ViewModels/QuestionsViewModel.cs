using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolBookMVC.ViewModels
{
    public class QuestionsViewModel
    {
        public IList<string> questions { get; set; }
        public IList<string> answers { get; set; }
        public int HomeWorkID { get; set; }
        public bool preview { get; set; }
    }

}

