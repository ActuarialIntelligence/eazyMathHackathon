using SchoolBook.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolBook.Infrastructure.Data.Dto;
using SchoolBook.Infrastructure.Interfaces;
using SchoolBook.Domain;

namespace SchoolBook.Logic
{
    public static class clsGr12 
    {
        private static string[] Operations = new string[4]{"+","-","/","*"};
        private static string[] Trig = new string[6] {"Sin","Cos","Tan","Sec","Cosec","Cot"};

        public static void ClearCache()
        {

        }

        public static string BasicTrigGen(IHomeworkParameters parameters)//Angle or side int 0 or 1
        {
            int AngleOrSide= parameters.AngleOrSide, maxSides=parameters.maxSides;
            try
            {
            Random rnd = new Random();
            string[] AngleSide = new string[2] { "angle", "sides" };
            string RetTrig="";
            if (AngleOrSide == 1)
            {
                RetTrig = RetTrig + "Find the ";
                RetTrig = RetTrig + AngleSide[0] + " of a triangle where " + Trig[rnd.Next(0, 5)] + "(x) has sides " + rnd.Next(1, maxSides).ToString() + "," + rnd.Next(1, maxSides).ToString();
            }

            if (AngleOrSide == 0)
            {
                RetTrig = RetTrig + "Find the ";
                RetTrig = RetTrig + AngleSide[1] + " of a triangle where " + Trig[rnd.Next(0, 5)] + "(x) has angle " + rnd.Next(0, 89).ToString() + " and numerator " + rnd.Next(1,120);
            }
            return RetTrig;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string LogEquations(IHomeworkParameters parameters)
        {
            int NoOfTerms=parameters.NoOfTerms, HighestNumber=parameters.HighestNumber
                , HighestNumberPow=parameters.HighestNumberPow;
            try
            {
            char[] XorNot = new char[2]{' ','x'};
            Random rnd = new Random();
            string Retlog = "";
            for( int i = 0 ; i<NoOfTerms; i++)
            {
                Retlog = Retlog + rnd.Next(1, HighestNumber).ToString() 
                        + "<sup>(" + rnd.Next(1, 45).ToString() + XorNot[1].ToString() 
                        + Operations[rnd.Next(0, 1)] + rnd.Next(1, HighestNumberPow).ToString() + ")</sup>";
                if (i != NoOfTerms - 1)
                {
                    Retlog = Retlog + Operations[rnd.Next(0, 1)];
                }
            }
            
            return Retlog+"=0";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string SequenceSeries(IHomeworkParameters parameters) // Complexity has three levels
        {
            int complexity= parameters.ComplexityID, 
                highest_a= parameters.highest_a, highest_n= parameters.highest_n, 
                highest_d=parameters.highest_d, highest_r= parameters.highest_r;
            string seq = "";
            try
            {
            double[] Arith = new double[5];
            string[] Art = new string[5] { "initial value", "common difference", "number of terms", "N<sub>th</sub> term", "arithmetic sum of n terms" };
            double[] Geom = new double[5];
            string[] Gm = new string[5] { "initial value", "common ratio", "number of terms", "N<sub>th</sub> term", "geometric sum" };
            Random rnd = new Random();
            int hold;

            Arith[0] = rnd.Next(1, highest_a);
            Arith[1] = rnd.Next(1, highest_d);
            Arith[2] = rnd.Next(1, highest_n);
            Arith[3] = Arith[0]+Arith[1]*(Arith[2]-1);// a,d,n,Nn
            Arith[4] = (Arith[2] / 2) * ((2 * Arith[0]) + Arith[1] * (Arith[2] - 1));// a,d,n,Sn

            Geom[0] = Arith[0];
            Geom[1] = rnd.Next(1, highest_r) / (highest_r*2);
            Geom[2] = Arith[2];
            Geom[3] = Geom[0] * Math.Pow(Geom[1], (Geom[2]-1));
            Geom[4] = Geom[0]*((Math.Pow(Geom[1],Geom[1])-1)/(Geom[1]-1));

                if (complexity == 2)
                {
                    // a,d,n,Nn
                    // a,d,n,Sn
                    hold = rnd.Next(0, 2);
                    seq = seq + "Given that the " + Art[hold] + " of an arithmetic progression is " + Arith[hold].ToString() + " and the sum up to n terms and the N<sup>th</sup> term are {" + Arith[4] +","+ Arith[3] + "} Respectively, calculate the remaining entities of the progression."; 

                }       
            return seq;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public static List<double> TrignometricTriangles(IHomeworkParameters parameters)
        {
            #region Formulae
            // a^2 = b^2 + c^2 + 2bcCosA 
            // a b c A
            // a^2 = b^2 + c^2
            // a b c
            // SinA/a = SinB/b
            // A,a,B,b
            // 1/2bcSinA 
            #endregion
            int DegreeOfRemoval= parameters.DegreeOfRemoval,  
                maxSides= parameters.maxSides, 
                AngleOrSide= parameters.AngleOrSide;

            Random rdm = new Random();// Use also to choose whether one or two sides will be in common
            List<double> TrigRet = new List<double>();
            double[,] Triangles = new double[12,3];
            
            double TempAngle;
            Triangles[0, 0] = rdm.Next(1, maxSides);
            Triangles[0, 1] = rdm.Next(1, maxSides);
            Triangles[0, 2] = Math.Pow(Math.Pow(Triangles[0, 0], 2) + Math.Pow(Triangles[0, 1], 2), 0.5);

            TrigRet.Add(Triangles[0, 0]);
            TrigRet.Add(Triangles[0, 1]);
            TrigRet.Add(Triangles[0, 2]);

            for (int i = 1; i < DegreeOfRemoval; i++)
            {
                if (AngleOrSide == 2)
                {
                    Triangles[i, 0] = Triangles[i - 1, 0];
                    Triangles[i, 1] = rdm.Next(1, maxSides);
                    TempAngle = rdm.Next(1, 80);
                    Triangles[i, 2] = Math.Pow(Math.Pow(Triangles[i, 0], 2) + Math.Pow(Triangles[i, 1], 2) - (2) * Triangles[i, 0] * Triangles[i, 1] * Math.Cos(TempAngle), 0.5);

                    TrigRet.Add(Triangles[i, 0]);
                    TrigRet.Add(Triangles[i, 1]);
                    TrigRet.Add(Triangles[i, 2]);

                    Triangles[i + 1, 0] = Triangles[i - 1, rdm.Next(1, 2)];
                    Triangles[i + 1, 1] = Triangles[i, rdm.Next(1, 2)];
                    TempAngle = rdm.Next(1, 80);
                    Triangles[i + 1, 2] = Math.Pow(Math.Pow(Triangles[i+1, 0], 2) + Math.Pow(Triangles[i+1, 1], 2) - (2) * Triangles[i+1, 0] * Triangles[i+1, 1] * Math.Cos(TempAngle), 0.5);
                    
                    TrigRet.Add(Triangles[i + 1, 0]);
                    TrigRet.Add(Triangles[i + 1, 1]);
                    TrigRet.Add(Triangles[i + 1, 2]);
                }
                if (AngleOrSide == 1)
                {
                    Triangles[i, 0] = Triangles[i - 1, 0];
                    Triangles[i, 1] = rdm.Next(1, maxSides);
                    Triangles[i, 2] = rdm.Next(1, maxSides);// angle of triangle

                    Triangles[i + 1, 0] = Triangles[i - 1, rdm.Next(1, 2)];
                    Triangles[i + 1, 1] = Triangles[i, rdm.Next(1, 2)];
                    Triangles[i + 1, 2] = rdm.Next(1, maxSides);

                    TrigRet.Add(Triangles[i, 0]);
                    TrigRet.Add(Triangles[i, 1]);                    
                    TrigRet.Add(Triangles[i, 2]);

                    TrigRet.Add(Triangles[i + 1, 0]);
                    TrigRet.Add(Triangles[i + 1, 1]);                    
                    TrigRet.Add(Triangles[i + 1, 2]);
                }
            }

            return TrigRet;
        }

        public static string TrigProblems(IHomeworkParameters parameters)
        {
            #region
            // a\u2072 = b^2 + c^2 + 2bcCosA 
            // a b c A 
            // a^2 = b^2 + c^2
            // a b c
            // SinA/a = SinB/b
            // A,a,B,b
            // 1/2bcSinA 
            // a,b,A,Area
            #endregion
            int DegreeOfRemoval = parameters.DegreeOfRemoval, 
                MaxSide= parameters.maxSides, AngleOrSide= parameters.AngleOrSide;
            try
            {
            string retPrb = "";
            int ArrayItems = 2 * (DegreeOfRemoval-1) + 1;
            List<double> Triangles = TrignometricTriangles(parameters);
            double[,] SidesAndAngles = new double[3*ArrayItems, 2];
            int[,] combinations = new int[DegreeOfRemoval, 9];
            int i = 0;
            foreach(double d in Triangles)
            {
                SidesAndAngles[i, 0] = Math.Round(d,2);
                i++;
            }
            int h=0;
            for (int j = 0; j < ArrayItems; j++)
            {
                h = 3*j;
                SidesAndAngles[h, 1] = Math.Round(Math.Acos((Math.Pow(SidesAndAngles[h + 1, 0], 2) + Math.Pow(SidesAndAngles[h + 2, 0], 2) - Math.Pow(SidesAndAngles[h, 0], 2)) / (2 * SidesAndAngles[h + 1, 0] * SidesAndAngles[h + 2, 0])), 2);
                SidesAndAngles[h + 1, 1] = Math.Round(Math.Acos((Math.Pow(SidesAndAngles[h, 0], 2) + Math.Pow(SidesAndAngles[h + 2, 0], 2) - Math.Pow(SidesAndAngles[h + 1, 0], 2)) / (2 * SidesAndAngles[h + 2, 0] * SidesAndAngles[h, 0])), 2);
                SidesAndAngles[h + 2, 1] = Math.Round(Math.Acos((Math.Pow(SidesAndAngles[h, 0], 2) + Math.Pow(SidesAndAngles[h + 1, 0], 2) - Math.Pow(SidesAndAngles[h + 2, 0], 2)) / (2 * SidesAndAngles[h + 1, 0] * SidesAndAngles[h, 0])), 2);
            }
            //< k, a, q> < k, b, j> < a, b, z>
            //<^k,^a,^q> <^k,^b,^j> <^a,^b,^z>
            // 3,5,7,9,....
            //[<^1,2,3><^1,^2>
            string[] ArbPortion  = new string[3]{"the area","the angles","the unknown side"};
            Random rdm = new Random();
            string solution = "$";
            solution = solution + SidesAndAngles[0, 0] + "," + SidesAndAngles[0, 1] + "," + SidesAndAngles[1, 0] + "," + SidesAndAngles[1, 1] + "," + SidesAndAngles[2, 0] + "," + SidesAndAngles[2, 1];
            retPrb = retPrb + "Given three interconnected triangles (A,B,C) where A,B have common side A<sub>1</sub> A,B,C having common sides A<sub>2</sub> and B<sub>2</sub> respectively.  with A having angle and sides ( ^A<sub>1</sub> " + SidesAndAngles[0, 1] + " ,A<sub>2</sub> " + SidesAndAngles[1, 0] + " ,A<sub>3</sub> " + SidesAndAngles[2, 0] + ") and B having angles ^B<sub>1</sub> " + SidesAndAngles[3, 1] + " ^B<sub>2</sub> " + SidesAndAngles[4, 1] + " and angle ^C " + SidesAndAngles[8, 1] + " where ^C is uncommon with A or B. Find " + ArbPortion[rdm.Next(0, 2)] + " of triangle C" + solution;
            // Find Area arbitrary angle or remaining side
            // Find the Area Height or angle
            return retPrb;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public static string TrigEqGen(IHomeworkParameters parameters)
        {
            int Complexity = parameters.ComplexityID;
            try
            {
            char[] Oper = new char[2]{'(',')'};
            string RetEq = "";
            Random rdm = new Random();
            string[,,] TrigStore = new string[13, 7, 3];            
            string Temp = "";
            string Temp2 = "";
            string Original = "";
            string[] SplitTemp;
            int StrCnt = 0;
            string Solution = "$";
            //string[,] SinStore = new string[7, 3];
            //string[,] CosStore = new string[7, 3];
            //string[,] TanStore = new string[7, 3];
            //string[,] CscStore = new string[7, 3];
            //string[,] SecStore = new string[7, 3];
            //string[,] CotStore = new string[7, 3];
            TrigStore[0, 0, 0] = "{Cos[x]}";
            TrigStore[1, 0, 0] = "{Sin[x]}";
            TrigStore[2, 0, 0] = "{Tan[x]}";
            TrigStore[3, 0, 0] = "{Csc[x]}";
            TrigStore[4, 0, 0] = "{Sec[x]}";
            TrigStore[5, 0, 0] = "{Cot[x]}";
            TrigStore[6, 0, 0] = "{Cos^2 [x]}";
            TrigStore[7, 0, 0] = "{Sin^2 [x]}";
            TrigStore[8, 0, 0] = "{Sec^2 [x]}";
            TrigStore[9, 0, 0] = "{Sin[2x]}";
            TrigStore[10, 0, 0] = "{Cos[2x]}";
            TrigStore[11, 0, 0] = "{Tan[2x]}";

            TrigStore[0, 1, 0] = "1/{Sec[x]}";
            TrigStore[0, 1, 1] = "/";
            TrigStore[1, 1, 0] = "1/{Csc[x]}";
            TrigStore[1, 1, 1] = "/";
            TrigStore[2, 1, 0] = "1/{Cot[x]}";
            TrigStore[2, 1, 1] = "/";
            TrigStore[3, 1, 0] = "1/{Cos[x]}";
            TrigStore[3, 1, 1] = "/";
            TrigStore[4, 1, 0] = "1/{Sin[x]}";
            TrigStore[4, 1, 1] = "/";
            TrigStore[5, 1, 0] = "1/{Tan[x]}";
            TrigStore[5, 1, 1] = "/";
            TrigStore[6, 1, 0] = "1-{Sin2 [x]}";
            TrigStore[6, 1, 1] = "-";
            TrigStore[7, 1, 0] = "1-{Cos2 [x]}";
            TrigStore[7, 1, 1] = "-";
            TrigStore[8, 1, 0] = "1+{Tan2 [x]}";
            TrigStore[8, 1, 1] = "+";
            TrigStore[9, 1, 0] = "2*{Sin[x]}*{Cos[x]}";
            TrigStore[9, 1, 1] = "*";

            TrigStore[0, 2, 0] = "1/{Sec[x]}";

            TrigStore[1, 2, 0] = "1/{Csc[x]}";

            TrigStore[2, 2, 0] = "{Sin[x]}/{Cos[x]}";

            TrigStore[3, 2, 0] = "1/{Cos[x]}";

            TrigStore[4, 2, 0] = "1/{Sin[x]}";

            TrigStore[5, 2, 0] = "{Cos[x]}/{Sin[x]}";

            TrigStore[6, 2, 0] = "1-{Sin^2 [x]}";

            TrigStore[7, 2, 0] = "1-{Cos^2 [x]}";

            TrigStore[8, 2, 0] = "1+{Sin^2 [x]}/{Cos2 [x]}";
            
            TrigStore[9, 2, 0] = "2*{Sin[x]}*{Cos[x]}";


            TrigStore[10, 1, 0] = "{Cos^2 [x]}-{Sin^2 [x]}";
            TrigStore[10, 2, 0] = "1-{2Sin^2 [x]}";

            TrigStore[11, 1, 0] = "2*Tan[x]/[1-Tan^2 [x]]";


            TrigStore[11, 2, 0] = "2*{Sin[x]}/{Cos[x]}/[{Cos^2 [x]}-(Sin^2 [x]}]";

                var tempRdm = rdm.Next(0, 10);
                var tempRdm2 = rdm.Next(0, 10);
            Temp = TrigStore[tempRdm, 0, 0] + "*" + TrigStore[tempRdm2, 0, 0];
            Original = Temp;
            SplitTemp = Temp.Split('*');
              
                foreach (string s in SplitTemp)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (s == TrigStore[i, 0, 0])
                        {
                            Solution = Solution + " Replace " + TrigStore[i, 1, 0] + " With " + SplitTemp[StrCnt];
                            SplitTemp[StrCnt] = "{"+TrigStore[i, 1, 0]+"}"; // Replaces the portion of the string with its counterpart.                           
                            break;
                        }
                    }
                    StrCnt++;
                }

                Temp = SplitTemp[0] + "*" + SplitTemp[1];
                Temp2 = Temp;
                StrCnt = 0;
                
                if (Complexity > 1)
                {
                    
                    SplitTemp = Temp.Split(Oper);

                    foreach (string s in SplitTemp)
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            if (s == TrigStore[i, 0, 0])
                            {
                                if (rdm.Next(1, 5) <= 3)
                                {
                                    Solution = Solution + " Replace " + TrigStore[i, 2, 0] + " With " + SplitTemp[StrCnt];
                                    SplitTemp[StrCnt] = "{" + TrigStore[i, 2, 0] + "}"; // Replaces the portion of the string with its counterpart.
                                    
                                }
                                break;
                            }
                        }
                        StrCnt++;
                    }
                    Temp = "";
                    foreach (string f in SplitTemp)
                    {
                        Temp = Temp + f;
                    }
                }
                string[] OriSpl = Original.Split('*');
    
            RetEq = RetEq+ "Prove That: " + OriSpl[1] + "={" + Temp +"}/{" + OriSpl[0]+ "}" + Solution;



            return RetEq;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string Cubic(IHomeworkParameters parameters)
        {
            try
            {
            string Cubic = "";
            Random rdm = new Random();
            int a, b, c;
            string Temp="";
            
            a = rdm.Next(1, 2);
            b = rdm.Next(1, 9);
            c = rdm.Next(1, 12);
            Temp = "Y=x<sup>3</sup>+(" + (a + b + c).ToString() + ")x<sup>2</sup>+(" + (a * b + b * c + a * c).ToString() + ")x+(" + (a * b * c).ToString() + ")";
            Cubic = Cubic + "Find the x-y intercepts and the turning points of the following cubic: "+ Temp;
            Cubic = Cubic + "$" + a.ToString() + "," + b.ToString() + "," + c.ToString();
            return Cubic;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string LinearProgramming(IHomeworkParameters parameters)
        {
            try
            {
            // Ususally involves two entities and one common factor such as hours spent
            string Linear = "";
            Random rdm = new Random();
            double[] LinearOperators = new double[8];

            LinearOperators[0] = (rdm.Next(1, 230) / 10);
            LinearOperators[1] = rdm.Next(0, 10);
            LinearOperators[2] = (rdm.Next(1, 230) / 10);
            LinearOperators[3] = rdm.Next(11, 100);
            LinearOperators[4] = (rdm.Next(1, 230) / 10);
            LinearOperators[5] = rdm.Next(0, 10);
            LinearOperators[6] = (rdm.Next(1, 230) / 10);
            LinearOperators[7] = rdm.Next(0, 10);


            Linear = Linear + "y > " + LinearOperators[0] + "x + " + LinearOperators[1] + " ; ";
            Linear = Linear + "y < " + LinearOperators[2] + "x + " + LinearOperators[3] + " ; ";
            Linear = Linear + "x > " + LinearOperators[4] + "y + " + LinearOperators[5] + " ; ";
            Linear = Linear + "x < " + LinearOperators[6] + "y + " + LinearOperators[7] + "";
            Linear = Linear + "$";
            foreach (double d in LinearOperators)
            {
                Linear = Linear + d.ToString() + ",";
            }
            return Linear;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string LineGraph(IHomeworkParameters parameters)
        {
            string LineGraph = "";
            Random rdm = new Random();
            LineGraph = LineGraph + "Find the line graph that passes through the points (" + rdm.Next(1, 45) + "," + rdm.Next(1, 45) + ") (" + rdm.Next(1, 45) + "," + rdm.Next(1, 45) + ")";
            return LineGraph;
        }

        public static string Differentiation(IHomeworkParameters parameters)
        {
            int complexity = parameters.ComplexityID;
            try
            {
            string DiffRet = "Differentiate the function: ";
            string[] Temp;            
            Temp = Cubic(new HomeworkGeneratorParameters()).Split('=');
            DiffRet = DiffRet + Temp[1]; 
            return DiffRet;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static void SimpleWordGen(IHomeworkParameters parameters)
        {

        }

    }
}
