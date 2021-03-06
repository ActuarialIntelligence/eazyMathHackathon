using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Domain.HomeWork
{
    public class HomeWork
    {
        public int HomeWorkID { get; set; }
        public string Questions { get; set; }
        public string Answers { get; set; }
        public string StudentAnswers { get; set; }
        public Nullable<int> IsCorrect { get; set; }
        public Nullable<decimal> Percentage_Correct { get; set; }
        public int SubSyllabusID { get; set; }
        public Nullable<DateTime> Date { get; set; }
        public int Grade { get; set; }
    }
}
