using SchoolBook.Domain.HomeWork;
using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Writers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Writers
{
    public class HomeWorkAssignWriter : IDataWriter<HomeWorkAssign>
    {
        private readonly SchoolBookEntities context;
        public HomeWorkAssignWriter(SchoolBookEntities context)
        {
            this.context = context;
        }

        public void WriteData(HomeWorkAssign entity)
        {
            var hw = new HomeWork_Assign();
            hw.Date = DateTime.UtcNow;
            hw.NoOfQuestions = (int)entity.NoOfQuestions;
            hw.SubSyllabusID = (int)entity.SubSyllabusID;
            context.HomeWork_Assign.Add(hw);
            context.SaveChanges();
        }
    }
}
