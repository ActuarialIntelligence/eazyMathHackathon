using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolBookMVC.Models
{
    public class QuestionsModel
    {
        public IList<string> questions { get; set; }
        public IList<string> answers { get; set; }
        public int homeWorkID { get; set; }
        public bool preview { get; set; }
    }
}