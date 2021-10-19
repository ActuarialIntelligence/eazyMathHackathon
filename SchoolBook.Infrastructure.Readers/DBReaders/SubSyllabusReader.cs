using SchoolBook.Domain;
using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Readers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Readers.DBReaders
{
    public class SubSyllabusReader : IDataReader<IList<SubSyllabus>>
    {
        private readonly SchoolBookEntities context;
        public SubSyllabusReader(SchoolBookEntities context)
        {
            this.context = context;
        }
        public IList<SubSyllabus> GetData(int id)
        {
            var results = context.SubSyllabus.Where(w => w.SyllabusID == id);
            var syllabusLList = new List<SubSyllabus>();
            foreach (var subSyllabus in results)
            {
                var item = new SubSyllabus();
                item.SyllabusID = subSyllabus.SyllabusID;
                item.SubSyllabusID = subSyllabus.ID;
                item.Name = subSyllabus.Name;
                syllabusLList.Add(item);
            }
            return syllabusLList;
        }
    }
}
