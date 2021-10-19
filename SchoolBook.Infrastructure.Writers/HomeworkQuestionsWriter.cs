using AutoMapper;
using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Data.Dto;
using SchoolBook.Infrastructure.Writers.Interfaces;

namespace SchoolBook.Infrastructure.Writers // entity framework is the connection for use.
{
    public class HomeworkQuestionsWriter : IDataWriter<SchoolBook.Domain.HomeWork.HomeWork> 
    {
        private SchoolBookEntities context;
        public HomeworkQuestionsWriter(SchoolBookEntities context)
        {
            this.context = context;
        }

        public void WriteData(SchoolBook.Domain.HomeWork.HomeWork entity)
        {
            
            var homeWork = new HomeWork();
            homeWork.Answers = entity.Answers;
            homeWork.HomeWorkID = entity.HomeWorkID;
            homeWork.IsCorrect = entity.IsCorrect;
            homeWork.Percentage_Correct = entity.Percentage_Correct;
            homeWork.StudentAnswers = entity.StudentAnswers;
            homeWork.Questions = entity.Questions;
            homeWork.SubSyllabusID = entity.SubSyllabusID;
            context.HomeWork.Add(homeWork);
            context.SaveChanges();
        }
    }
}
