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
    public class TutorReader
    {
        private readonly SchoolBookEntities context;
        public TutorReader(SchoolBookEntities context)
        {
            this.context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">StudentID</param>
        /// <returns></returns>
        public Tutor GetData(int id)
        {
            var result = context.TutorTables.SingleOrDefault(s => s.TutorID == id);
            var tutor = new Tutor();
            tutor.ID = result.TutorID;
            tutor.Name = result.Name;
            tutor.ImgUrl = result.ImgUrl;
            return tutor;
        }
    }

   
}
