using SchoolBook.Domain.HomeWork;
using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Readers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Readers
{
    public class HomeWorkAssignmentReader : IDataReader<HomeWorkAssign> 
    {
        private readonly SchoolBookEntities context;
        public HomeWorkAssignmentReader(SchoolBookEntities context)
        {
            this.context = context;
        }

        public HomeWorkAssign GetData(int id)
        {
            var entityRow = context.HomeWork_Assign.Single(r => r.HomeWorkID == id);
            var homeworkDetails = new HomeWorkAssign(entityRow.HomeWorkID,
                entityRow.SubSyllabusID, entityRow.NoOfQuestions,entityRow.Date);

            return homeworkDetails;
        }
    }
}
