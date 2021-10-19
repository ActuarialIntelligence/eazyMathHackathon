using SchoolBook.Domain;
using SchoolBook.Logic;
using System;
using System.Collections.Generic;



namespace EXEtest
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //var module = new BaseNinjectModule();
            //var kernel = new StandardKernel(module);
            //var readerHomework = kernel.Get<IDataReader<HomeWorkAssign>>();

            //var homeWorkDetails = readerHomework.GetData(1);

            var questions = new List<string>();
            var parameter = new HomeworkParameters();
            parameter.ComplexityID = 2;// (int)homeWorkDetails.ComplexityID;
            for (int i = 0; i < 5; i++)
            {
                var function = Gr12Wrapper.GetSubSyllabusQuestionGenerator(5);
                var temp = function.Invoke(parameter);
                questions.Add(temp);
                function = null;
                IntervalTimer_Elapsed();
            }  
            
            
             
        }

        private static void IntervalTimer_Elapsed()
        {
            var timeAtBeginningOfFunction = DateTime.Now;
            var timeCnt = DateTime.Now.Second;
            int total=0;
            for(int i=0; i<50000000000000000;i++ )
            {
                total = (DateTime.Now - timeAtBeginningOfFunction).Seconds;
                if (total > 0.5)
                {
                    break;
                }
            }
            Console.WriteLine("Kill Me !!");
        }
    }
}
