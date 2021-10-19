using SchoolBook.Domain.HomeWork;
using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Readers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Readers.DBReaders
{
    public class HomeWorksReader: IDateGradeParametricDataReader<IList<SchoolBook.Domain.HomeWork.HomeWork>>
    {
        private readonly SchoolBookEntities context;
        public HomeWorksReader(SchoolBookEntities context)
        {
            this.context = context;
        }

        public IList<SchoolBook.Domain.HomeWork.HomeWork> GetData(DateTime date,int gradeId)
        {
            var dateDate = date.Year + "-" + "08" + "-" + "05";
            var list = new List<SchoolBook.Domain.HomeWork.HomeWork>();
            var result = context.HomeWork.Where(w=> context.HomeWork_Assign.Where(r => (r.Date.Value.Year + "-" + "08" + "-" + "05").ToString() == (dateDate))
                .Select(s => s.HomeWorkID ).ToList().Contains(w.HomeWorkID)).ToList();

            foreach(var value in result)
            {
                var homework = new SchoolBook.Domain.HomeWork.HomeWork();
                homework.Answers = value.Answers;
                homework.StudentAnswers = value.StudentAnswers;
                homework.Date = date;
                homework.HomeWorkID = value.HomeWorkID;
                homework.IsCorrect = value.IsCorrect;
                homework.Percentage_Correct = value.Percentage_Correct;
                homework.Questions = value.Questions;
                homework.SubSyllabusID = value.SubSyllabusID;
                list.Add(homework);
            }

            return list;
        }
    }
}
