using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Data.Dto;
using SchoolBook.Infrastructure.Writers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Writers
{
    public class ParametersWriter : IDataWriter<ParametersDto>
    {
        private readonly SchoolBookEntities context;
        public ParametersWriter(SchoolBookEntities context)
        {
            this.context = context;
        }

        public void WriteData(ParametersDto entity)
        {
            var parameter = new HomeworkParameter();
            parameter.AngleOrSide = entity.AngleOrSide;
            parameter.ArithOrGeom = entity.ArithOrGeom;
            parameter.ComplexityID = entity.ComplexityID;
            parameter.DegreeOfRemoval = entity.DegreeOfRemoval;
            parameter.HighestNumber = entity.HighestNumber;
            parameter.HighestNumberPow = entity.HighestNumberPow;
            parameter.highest_a = entity.highest_a;
            parameter.highest_d = entity.highest_d;
            parameter.highest_n = entity.highest_n;
            parameter.highest_r = entity.highest_r;
            parameter.maxSides = entity.maxSides;
            parameter.NoOfLawsInUse = entity.NoOfLawsInUse;
            parameter.NoOfTerms = entity.NoOfTerms;
            context.HomeworkParameters.Add(parameter);
            context.SaveChanges();
        }
    }
}
