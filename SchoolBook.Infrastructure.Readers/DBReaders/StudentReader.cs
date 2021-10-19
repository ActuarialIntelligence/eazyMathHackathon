using SchoolBook.Domain.StudentTeacher;
using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Readers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Readers.DBReaders
{
    
    public class StudentReader : IDataReader<Student>
    {
        private readonly SchoolBookEntities context;
        public StudentReader(SchoolBookEntities context)
        {
            this.context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">StudentID</param>
        /// <returns></returns>
        public Student GetData(int id)
        {
            var result = context.StudentTables.SingleOrDefault(s => s.StudentID == id);
            var student = new Student();
            student.ID = result.StudentID;
            student.Name = result.Name;
            student.ImgUrl = result.ImgUrl;
            return student;
        }
    }
}
