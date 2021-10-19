using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolBookMVC.ViewModels
{
    public class HomeWorkParameters
    {
        public Nullable<int> NoOfTerms { get; set; }
        public Nullable<int> NoOfLawsInUse { get; set; }
        public Nullable<decimal> HighestNumber { get; set; }
        public Nullable<int> HighestNumberPow { get; set; }
        public Nullable<int> ComplexityID { get; set; }
        public Nullable<int> ArithOrGeom { get; set; }
        public Nullable<decimal> Highest_a { get; set; }
        public Nullable<int> Highest_n { get; set; }
        public Nullable<decimal> Highest_d { get; set; }
        public Nullable<decimal> Highest_r { get; set; }
        public Nullable<int> DegreeOfRemoval { get; set; }
        public Nullable<int> MaxSides { get; set; }
        public Nullable<int> AngleOrSide { get; set; }
    }
}