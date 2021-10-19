using SchoolBook.Domain.StudentTeacher;
using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Writers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Writers
{
    public class StudentTeacherPairingWritercs : IDataWriter<IList<StudentTeacherRelationship>>
    {
        private readonly SchoolBookEntities context;
        public StudentTeacherPairingWritercs(SchoolBookEntities context)
        {
            this.context = context;
        }

        public void WriteData(IList<StudentTeacherRelationship> entities)
        {
            foreach(var entity in entities)
            {
                var relation = new TutorStudentRelationship();
                relation.StudentID = entity.StudentID;
                relation.TutorID = entity.TutorID;
                context.TutorStudentRelationships.Add(relation);
            }
            context.SaveChanges();
        }
    }
}
