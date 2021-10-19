using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Logic.Interfaces
{
    public interface IGrade12
    {
        string TrigEqGen(int Complexity);
        string TrigProblems(int DegreeOfRemoval, int MaxSide, int AngleOrSide);
        List<double> TrignometricTriangles(int DegreeOfRemoval, int maxSides, int AngleOrSide);
    }
}
