using AutoMapper;
using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Data.Dto;
using SchoolBook.Infrastructure.Writers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Writers
{
    public class AnswersWriter : IWriter<string>
    {
        private SchoolBookEntities context;
        public AnswersWriter(SchoolBookEntities context)
        {
            this.context = context;
        }

        public void WriteData(string value,int id)
        {
            var result = context.HomeWork.FirstOrDefault(f => f.HomeWorkID == id);
            if (result != null)
            {
                result.StudentAnswers = value;
            }
            context.SaveChanges();
        }
    }
}
