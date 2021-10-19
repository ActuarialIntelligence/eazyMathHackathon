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
    public class StudentsByPlaceNotPairedWithTutorReader : IDataReader<IList<Student>>
    {
        private readonly SchoolBookEntities context;
        public StudentsByPlaceNotPairedWithTutorReader(SchoolBookEntities context)
        {
            this.context = context;
        }

        public IList<Student> GetData(int id)
        {

            var list = context.TutorStudentRelationships.Where(w => w.TutorID == id).Select(s => s.StudentID).ToList();
            var existingStudentIDList = context.StudentTables.Where(f => list.Contains(f.StudentID)).Select(s=>s.StudentID).ToList();

            var tutor = context.TutorTables.SingleOrDefault(d => d.TutorID == id);
            var students = context.StudentTables.Where(w => w.PlaceKey == tutor.PlaceKey);
            var stdList = new List<Student>();
            foreach (var s in students)
            {
                if (!existingStudentIDList.Contains(s.StudentID))
                {
                    var student = new Student();
                    student.ID = s.StudentID;
                    student.Name = s.Name;
                    student.ImgUrl = s.ImgUrl;
                    student.PlaceKey = s.PlaceKey;
                    stdList.Add(student);
                }
            }
            return stdList;
        }
    }
}
