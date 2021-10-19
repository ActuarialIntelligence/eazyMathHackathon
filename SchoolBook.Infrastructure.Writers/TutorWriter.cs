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
    public class TutorWriter : IDataWriter<Tutor>
    {
        private readonly SchoolBookEntities context;
        public TutorWriter(SchoolBookEntities context)
        {
            this.context = context;
        }

        public void WriteData(Tutor entity)
        {
            //var result = context.TutorTables.SingleOrDefault(s => s.TutorID == entity.ID);
            var tut = new TutorTable();
            tut.Name = entity.Name;
            tut.ImgUrl = entity.ImgUrl;
            tut.PlaceKey = entity.PlaceKey;
            context.TutorTables.Add(tut);
            context.SaveChanges();
        }
    }
}
