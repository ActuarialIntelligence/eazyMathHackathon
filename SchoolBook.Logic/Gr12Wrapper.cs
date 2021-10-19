using SchoolBook.Domain;
using SchoolBook.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Logic
{
    public static class Gr12Wrapper
    {
        public static Func<IHomeworkParameters, string> GetSubSyllabusQuestionGenerator(int index)
        {
            IList<Triplet> tripletList = new List<Triplet>()
            {
                new Triplet(1,"BasicTrigGen",clsGr12.BasicTrigGen),
                new Triplet(2,"Integration by Parts",UniversityIntegration.IntegrationByParts),
                new Triplet(3,"SequenceSeries",clsGr12.SequenceSeries),
                new Triplet(4,"TrigProblems",clsGr12.TrigProblems),
                new Triplet(5,"TrigEqGen",clsGr12.TrigEqGen),
                new Triplet(6,"Cubic",clsGr12.Cubic),
                new Triplet(7,"LinearProgramming",clsGr12.LinearProgramming),
                new Triplet(8,"LineGraph",clsGr12.LineGraph),
                new Triplet(9,"Differentiation",clsGr12.Differentiation),
                new Triplet(10,"LogEquations",clsGr12.LogEquations)

            };

            return tripletList.Single(r => r.index == index).function;
        }
    }
}
