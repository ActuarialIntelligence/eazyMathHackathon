using System;

namespace SchoolBook.Domain.HomeWork
{
    public class HomeWorkAssign
    {
        public int HomeMorkID { get; private set; }
        public int? SubSyllabusID { get; private set; }
        public int? NoOfQuestions { get; private set; }
        public Nullable<System.DateTime> Date { get; private set; }

        public HomeWorkAssign(int HomeMorkID,
                              int? SubSyllabusID,
                              int? NoOfQuestions,
                              Nullable<System.DateTime> Date)
        {
            this.HomeMorkID = HomeMorkID;
            this.SubSyllabusID = SubSyllabusID;
            this.NoOfQuestions = NoOfQuestions;
            this.Date = Date;
        }
    }
}
