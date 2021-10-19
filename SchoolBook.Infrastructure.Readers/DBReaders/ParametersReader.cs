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
    public class ParametersReader : IDataReader<Parameters>
    {
        private readonly SchoolBookEntities context;
        public ParametersReader(SchoolBookEntities context)
        {
            this.context = context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">HomeworkID</param>
        /// <returns></returns>
        public Parameters GetData(int id)
        {
            var result = context.HomeworkParameters.FirstOrDefault(s => 
            s.ParametersID == 
            s.HomeWorkParametersStudentPairings.FirstOrDefault(d => d.HomeWorkID == id).ParametersID);

            var parameters = new Parameters();
            parameters.AngleOrSide = result.AngleOrSide;
            parameters.ArithOrGeom = result.ArithOrGeom;
            parameters.ComplexityID = result.ComplexityID;
            parameters.DegreeOfRemoval = result.DegreeOfRemoval;
            parameters.HighestNumber = result.HighestNumber;
            parameters.HighestNumberPow = result.HighestNumberPow;
            parameters.highest_a = result.highest_a;
            parameters.highest_d = result.highest_d;
            parameters.highest_n = result.highest_n;
            parameters.highest_r = result.highest_r;
            parameters.maxSides = result.maxSides;
            parameters.NoOfLawsInUse = result.NoOfLawsInUse;
            parameters.NoOfTerms = result.NoOfTerms;
            parameters.ParametersID = result.ParametersID;

            return parameters;
        }
    }
}
