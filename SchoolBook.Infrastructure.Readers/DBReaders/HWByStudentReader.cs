using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Readers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Readers.DBReaders
{
    public class HWByStudentReader : IDataReader<int>
    {
        private readonly SchoolBookEntities context;
        public HWByStudentReader(SchoolBookEntities context)
        {
            this.context = context;
        }
        /// <summary>
        /// Pairing ID gets updated with every new HomeWork Assignment.
        /// </summary>
        /// <param name="id">StudentId</param>
        public int GetData(int id)
        {
            var pairingId = context.PairingStudentPairings.SingleOrDefault(s=>s.StudentID == id).PairingID;
            var homeWorkId = context.HomeWorkParametersStudentPairings.FirstOrDefault(s => s.PairingID == pairingId).HomeWorkID;
            return homeWorkId;
        }
    }
}
