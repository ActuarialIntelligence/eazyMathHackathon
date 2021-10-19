using SchoolBook.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Domain
{
    public class HomeworkParameters : IHomeworkParameters
    {
        public int ParametersID { get; set; }
        public int SubSyllabusID { get; set; }
        public int NoOfTerms { get; set; }
        public int NoOfLawsInUse { get; set; }
        public int HighestNumber { get; set; }
        public int HighestNumberPow { get; set; }
        public int ComplexityID { get; set; }
        public int ArithOrGeom { get; set; }
        public int highest_a { get; set; }
        public int highest_n { get; set; }
        public int highest_d { get; set; }
        public int highest_r { get; set; }
        public int DegreeOfRemoval { get; set; }
        public int maxSides { get; set; }
        public int AngleOrSide { get; set; }
    }
}
