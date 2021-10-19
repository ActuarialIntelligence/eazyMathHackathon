using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class clsGr12
    {
        string[] Operations = new string[4]{"+","-","/","*"};
        string[] Trig = new string[6] {"Sin","Cos","Tan","Sec","Cosec","Cot"};
        List<double> TrigRet;

        //Program Solutions

        //Simple gr8 Equations
        public string gr8EquationGen(int noOfTerms,int Highestvalue,int HighestNoOfTermsPerTerm)
        {
            try
            {
            string Eqreturn = "";
            Random rnd = new Random();
            Random Ope = new Random();
            Random RdmTerms = new Random();
            if (HighestNoOfTermsPerTerm == 1)
            {
                for (int i = 0; i < noOfTerms; i++)
                {
                    Eqreturn = "(x";
                    Eqreturn = Eqreturn + Operations[Ope.Next(0, 1)] + rnd.Next(1, Highestvalue).ToString();
                    Eqreturn = Eqreturn + ")";
                    if (i != noOfTerms - 1)
                    {
                        Eqreturn = Eqreturn + Operations[Ope.Next(0, 3)];
                    }
                }
            }
            if (HighestNoOfTermsPerTerm > 1)
            {
                for (int j = 0; j < noOfTerms;j++)
                {
                    Eqreturn = Eqreturn + "[";
                    int Runs = RdmTerms.Next(1, HighestNoOfTermsPerTerm);
                    for (int i = 0; i < Runs; i++)
                    {
                        Eqreturn = Eqreturn + "(x";
                        Eqreturn = Eqreturn + Operations[Ope.Next(0, 1)] + rnd.Next(1, Highestvalue).ToString();
                        Eqreturn = Eqreturn + ")";
                        if(i!=Runs-1)
                        {
                        Eqreturn = Eqreturn + Operations[Ope.Next(0, 3)];
                        }
                    }
                    Eqreturn = Eqreturn + "]";
                    if (j != noOfTerms - 1)
                    {
                        Eqreturn = Eqreturn + Operations[Ope.Next(0, 2)];
                    }
                }

            }
            string[] Solution = Eqreturn.Split('x');
            return Eqreturn;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public string BasicTrigGen(int AngleOrSide, int maxSides)//Angle or side int 0 or 1
        {
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

        public string LogEquations(int NoOfTerms, int NoOfLawsInUse, int HighestNumber, int HighestNumberPow)
        {
            try
            {
            char[] XorNot = new char[2]{' ','x'};
            Random rnd = new Random();
            string Retlog = "";
            for( int i = 0 ; i<NoOfTerms; i++)
            {
                Retlog = Retlog + rnd.Next(1, HighestNumber).ToString() + "<sup>(" + rnd.Next(1, 45).ToString() + XorNot[1].ToString() + Operations[rnd.Next(0, 1)] + rnd.Next(1, HighestNumberPow).ToString() + ")</sup>";
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

        public string SequenceSeries(int complexity,int ArithOrGeom, int highest_a,int highest_n,int highest_d, int highest_r) // Complexity has three levels
        {
            try
            {
            double[] Arith = new double[5];
            string[] Art = new string[5] { "initial value", "common difference", "number of terms", "N<sub>th</sub> term", "arithmetic sum of n terms" };
            double[] Geom = new double[5];
            string[] Gm = new string[5] { "initial value", "common ratio", "number of terms", "N<sub>th</sub> term", "geometric sum" };
            Random rnd = new Random();
            int hold;
            //int hold2;

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

            string seq = "";

            if (complexity == 1)
            {

            }
            if (complexity == 2)
            {
                // a,d,n,Nn
                // a,d,n,Sn
                hold = rnd.Next(0, 2);
                seq = seq + "Given that the " + Art[hold] + " of an arithmetic progression is " + Arith[hold].ToString() + " and the sum up to n terms and the N<sup>th</sup> term are {" + Arith[4] +","+ Arith[3] + "} Respectively, calculate the remaining entities of the progression."; 

            }
            if (complexity == 3)
            {
                
            }

            return seq;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public List<double> TrignometricTriangles(int DegreeOfRemoval, int maxSides, int AngleOrSide)
        {
            try
            {
            // a^2 = b^2 + c^2 + 2bcCosA 
            // a b c A
            // a^2 = b^2 + c^2
            // a b c
            // SinA/a = SinB/b
            // A,a,B,b
            // 1/2bcSinA 

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
                
                //AngleOrSide = rdm.Next(1,2);

                if (AngleOrSide == 2)
                {
                    Triangles[i, 0] = Triangles[i - 1, 0];
                    Triangles[i, 1] = rdm.Next(1, maxSides);
                    TempAngle = rdm.Next(1, 80);
                    Triangles[i, 2] = Math.Pow(Math.Pow(Triangles[i, 0], 2) + Math.Pow(Triangles[i, 1], 2) - (2) * Triangles[i, 0] * Triangles[i, 1] * Math.Cos(TempAngle), 0.5);

                    TrigRet.Add(Triangles[i, 0]);
                    TrigRet.Add(Triangles[i, 1]);
                    //TrigRet.Add(TempAngle.ToString());
                    TrigRet.Add(Triangles[i, 2]);

                    Triangles[i + 1, 0] = Triangles[i - 1, rdm.Next(1, 2)];
                    Triangles[i + 1, 1] = Triangles[i, rdm.Next(1, 2)];
                    TempAngle = rdm.Next(1, 80);
                    Triangles[i + 1, 2] = Math.Pow(Math.Pow(Triangles[i+1, 0], 2) + Math.Pow(Triangles[i+1, 1], 2) - (2) * Triangles[i+1, 0] * Triangles[i+1, 1] * Math.Cos(TempAngle), 0.5);
                    
                    TrigRet.Add(Triangles[i + 1, 0]);
                    TrigRet.Add(Triangles[i + 1, 1]);
                    //TrigRet.Add(TempAngle.ToString());
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
            catch (Exception)
            {
                return null;
            }
        }
        public string TrigProblems(int DegreeOfRemoval, int MaxSide, int AngleOrSide)
        {
            try
            {
            string retPrb = "";
            int ArrayItems = 2 * (DegreeOfRemoval-1) + 1;
            List<double> Triangles = TrignometricTriangles(DegreeOfRemoval, MaxSide,AngleOrSide);
            double[,] SidesAndAngles = new double[3*ArrayItems, 2];
            int[,] combinations = new int[DegreeOfRemoval, 9];
            // a\u2072 = b^2 + c^2 + 2bcCosA 
            // a b c A 
            // a^2 = b^2 + c^2
            // a b c
            // SinA/a = SinB/b
            // A,a,B,b
            // 1/2bcSinA 
            // a,b,A,Area
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
            catch (Exception)
            {
                return "";
            }
        }

        public string TrigEqGen(int Complexity)
        {
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
            string TempInLoop = "";
            int StrCnt = 0;
            string Solution = "$";
            //string[,] SinStore = new string[7, 3];
            //string[,] CosStore = new string[7, 3];
            //string[,] TanStore = new string[7, 3];
            //string[,] CscStore = new string[7, 3];
            //string[,] SecStore = new string[7, 3];
            //string[,] CotStore = new string[7, 3];
            TrigStore[0, 0, 0] = "Cos[x]";
            TrigStore[1, 0, 0] = "Sin[x]";
            TrigStore[2, 0, 0] = "Tan[x]";
            TrigStore[3, 0, 0] = "Csc[x]";
            TrigStore[4, 0, 0] = "Sec[x]";
            TrigStore[5, 0, 0] = "Cot[x]";
            TrigStore[6, 0, 0] = "Cos<sup>2</sup> [x]";
            TrigStore[7, 0, 0] = "Sin<sup>2</sup> [x]";
            TrigStore[8, 0, 0] = "Sec<sup>2</sup> [x]";
            TrigStore[9, 0, 0] = "Sin[2x]";
            TrigStore[10, 0, 0] = "Cos[2x]";
            TrigStore[11, 0, 0] = "Tan[2x]";

            TrigStore[0, 1, 0] = "<sup>1</sup><span>/<sub>(Sec[x])</sub>";
            TrigStore[0, 1, 1] = "/";
            TrigStore[1, 1, 0] = "<sup>1</sup><span>/<sub>(Csc[x])</sub>";
            TrigStore[1, 1, 1] = "/";
            TrigStore[2, 1, 0] = "<sup>1</sup><span>/<sub>(Cot[x])</sub>";
            TrigStore[2, 1, 1] = "/";
            TrigStore[3, 1, 0] = "<sup>1</sup><span>/<sub>(Cos[x])</sub>";
            TrigStore[3, 1, 1] = "/";
            TrigStore[4, 1, 0] = "<sup>1</sup><span>/<sub>(Sin[x])</sub>";
            TrigStore[4, 1, 1] = "/";
            TrigStore[5, 1, 0] = "<sup>1</sup><span>/<sub>(Tan[x])</sub>";
            TrigStore[5, 1, 1] = "/";
            TrigStore[6, 1, 0] = "1-(Sin<sup>2</sup> [x])";
            TrigStore[6, 1, 1] = "-";
            TrigStore[7, 1, 0] = "1-(Cos<sup>2</sup> [x])";
            TrigStore[7, 1, 1] = "-";
            TrigStore[8, 1, 0] = "1+(Tan<sup>2</sup> [x])";
            TrigStore[8, 1, 1] = "+";
            TrigStore[9, 1, 0] = "2*(Sin[x])*(Cos[x])";
            TrigStore[9, 1, 1] = "*";

            TrigStore[0, 2, 0] = "<sup>1</sup>/<sub>(Sec[x])</sub>";

            TrigStore[1, 2, 0] = "<sup>1</sup>/<sub>(Csc[x])</sub>";

            TrigStore[2, 2, 0] = "<sup>(Sin[x])</sup>/<sub>(Cos[x])</sub>";

            TrigStore[3, 2, 0] = "<sup>1</sup>/<sub>(Cos[x])</sub>";

            TrigStore[4, 2, 0] = "<sup>1</sup>/<sub>(Sin[x])</sub>";

            TrigStore[5, 2, 0] = "<sup>(Cos[x])</sup>/<sub>(Sin[x])</sub>";

            TrigStore[6, 2, 0] = "1-(Sin<sup>2</sup> [x])";

            TrigStore[7, 2, 0] = "1-(Cos<sup>2</sup> [x])";

            TrigStore[8, 2, 0] = "1+<sup>(Sin<sup>2</sup> [x])</sup><span>/<sub>(Cos<sup>2</sup> [x])</sub>";
            
            TrigStore[9, 2, 0] = "2*(Sin[x])*(Cos[x])";


            TrigStore[10, 1, 0] = "(Cos<sup>2</sup> [x])-(Sin<sup>2</sup> [x])";
            TrigStore[10, 2, 0] = "1-(2Sin<sup>2</sup> [x])";

            TrigStore[11, 1, 0] = "<sup>2*Tan[x]</sup><span>/<sub>[1-Tan<sup>2</sup> [x]]</sub>";


            TrigStore[11, 2, 0] = "<sup>2*(Sin[x])/(Cos[x])</sup><span>/<sub>[(Cos<sup>2</sup> [x])-(Sin<sup>2</sup> [x])]</sub>";
            

            Temp = TrigStore[rdm.Next(0, 10), 0, 0] + "*" + TrigStore[rdm.Next(0, 10), 0, 0];
            Original = Temp;
            SplitTemp = Temp.Split('*');

            //for (int j = 0; j < Complexity; j++)
            //{               
                foreach (string s in SplitTemp)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (s == TrigStore[i, 0, 0])
                        {
                            Solution = Solution + " Replace " + TrigStore[i, 1, 0] + " With " + SplitTemp[StrCnt];
                            SplitTemp[StrCnt] = "{"+TrigStore[i, 1, 0]+"}"; // Replaces the portion of the string with its counterpart.
                            
                            //if (StrCnt != 0)
                            //{                            
                            //}
                            break;
                        }
                    }
                    StrCnt++;
                }

                Temp = SplitTemp[0] + "*" + SplitTemp[1];
                Temp2 = Temp;
               // SplitTemp = Temp.Split(Oper);
            //}
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
                                //if (StrCnt != 0)
                                //{                            
                                //}
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
    
            RetEq = RetEq+"Prove That: " + OriSpl[1] +"=<sup>{"+ Temp +"}</sup>/<sub>(" + OriSpl[0]+")</sub>"+Solution;



            return RetEq;
            }
            catch (Exception)
            {
                return "";
            }
        }
        public string Cubic()
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
        public string LinearProgramming()
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
        public string LineGraph()
        {
            string LineGraph = "";
            Random rdm = new Random();
            LineGraph = LineGraph + "Find the line graph that passes through the points (" + rdm.Next(1, 45) + "," + rdm.Next(1, 45) + ") (" + rdm.Next(1, 45) + "," + rdm.Next(1, 45) + ")";
            return LineGraph;
        }

        public string Differentiation(int complexity)
        {
            try
            {
            string DiffRet = "Differentiate the function: ";
            string[] Temp;            
            Temp = Cubic().Split('=');
            DiffRet = DiffRet + Temp[1]; 
            return DiffRet;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public void SimpleWordGen()
        {

        }




    }
}
