using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Interfaces
{
    public interface IHomeworkParameters 
    {
        int NoOfTerms{get;set;}
        int NoOfLawsInUse{get;set;}
        int HighestNumber{get;set;}
        int HighestNumberPow{get;set;}
         int ComplexityID{get;set;}
         int ArithOrGeom{get;set;}
         int highest_a{get;set;}
         int highest_n{get;set;}
        int highest_d{get;set;}
        int highest_r{get;set;}
         int DegreeOfRemoval{get;set;}
        int maxSides{get;set;}
        int AngleOrSide{get;set;}
    }
}
