using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Writers.Interfaces;
using System.Linq;

namespace SchoolBook.Infrastructure.Writers
{
    public class MarksUpdater : IDataWriter<SchoolBook.Domain.HomeWork.HomeWork>
    {
        private SchoolBookEntities context;
        public MarksUpdater(SchoolBookEntities context)
        {
            this.context = context;
        }

        public void WriteData(SchoolBook.Domain.HomeWork.HomeWork entity)
        {
            var result = context.HomeWork.SingleOrDefault(s => s.HomeWorkID == entity.HomeWorkID);
            result.Percentage_Correct = entity.Percentage_Correct;
            context.HomeWork.Add(result);
            context.SaveChanges();
        }
    }
}
