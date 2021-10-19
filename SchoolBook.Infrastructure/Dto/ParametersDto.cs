using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Data.Dto
{
    public class ParametersDto
    {
        public int ParametersID { get; set; }
        public int SubSyllabusID { get; set; }
        public Nullable<int> NoOfTerms { get; set; }
        public Nullable<int> NoOfLawsInUse { get; set; }
        public Nullable<decimal> HighestNumber { get; set; }
        public Nullable<int> HighestNumberPow { get; set; }
        public Nullable<int> ComplexityID { get; set; }
        public Nullable<int> ArithOrGeom { get; set; }
        public Nullable<decimal> highest_a { get; set; }
        public Nullable<int> highest_n { get; set; }
        public Nullable<decimal> highest_d { get; set; }
        public Nullable<decimal> highest_r { get; set; }
        public Nullable<int> DegreeOfRemoval { get; set; }
        public Nullable<int> maxSides { get; set; }
        public Nullable<int> AngleOrSide { get; set; }
    }
}
