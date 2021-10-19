using SchoolBook.Domain.HomeWork;
using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Readers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Readers.DBReaders
{
    public class PerformanceStatisticsReader : IDatedDataReader<SubSyllabusByPercentage>
    {
        private readonly SchoolBookEntities context;
        public PerformanceStatisticsReader(SchoolBookEntities context)
        {
            this.context = context;
        }
        public SubSyllabusByPercentage GetData(int id,DateTime date)
        {
            var percentageByHomeWork = context.HomeWork
                .Where(w => context.HomeWorkParametersStudentPairings
                .Where(s => s.PairingID == context.PairingStudentPairings.SingleOrDefault(p => p.StudentID == id && p.DateTime == date).PairingID)
                .Select(s => s.HomeWorkID)
                .ToList().Contains(w.HomeWorkID))
                .GroupBy(g => new { g.HomeWorkID , g})
                .Select(s=>new { key = s.Key.HomeWorkID, sum = s.Sum(f => f.Percentage_Correct) }).ToList();

            throw new NotImplementedException();
        }
    }
}
