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
    public class StudentsByTutorIDReader : IDataReader<IList<Student>>
    {
        private readonly SchoolBookEntities context;
        public StudentsByTutorIDReader(SchoolBookEntities context)
        {
            this.context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<Student> GetData(int id)
        {
            var list = context.TutorStudentRelationships.Where(w => w.TutorID == id).Select(s=>s.StudentID).ToList();
            var studentList = context.StudentTables.Where(f => list.Contains(f.StudentID));
            var students = new List<Student>();
            foreach (var value in studentList)
            {
                var stdnt = new Student();
                stdnt.ID = value.StudentID;
                stdnt.Name = value.Name;
                stdnt.ImgUrl = value.ImgUrl;
                students.Add(stdnt);
            }
            return students;
        }
    }
}
