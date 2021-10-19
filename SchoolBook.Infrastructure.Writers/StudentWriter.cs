using SchoolBook.Domain.StudentTeacher;
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
    public class StudentWriter:IDataWriter<Student>
    {
        private readonly SchoolBookEntities context;
        public StudentWriter(SchoolBookEntities context)
        {
            this.context = context;
        }

        public void WriteData(Student entity)
        {
            //var result = context.StudentTables.SingleOrDefault(s => s.StudentID == entity.ID);
            var stdnt = new StudentTable();
            stdnt.Name = entity.Name;
            stdnt.ImgUrl = entity.ImgUrl;
            stdnt.PlaceKey = entity.PlaceKey;
            stdnt.EmailAddress = entity.EmailAddress;
            
            context.StudentTables.Add(stdnt);
            context.SaveChanges();
        }
    }
}
