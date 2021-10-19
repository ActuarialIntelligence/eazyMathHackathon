using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class clsGr10
    {
        public string LineGraph()
        {
            string LineGraph = "";
            Random rdm = new Random();
            LineGraph = LineGraph + "Find the line graph that passes through the points (" + rdm.Next(1, 45) + "," + rdm.Next(1, 45) + ") (" + rdm.Next(1, 45) + "," + rdm.Next(1, 45) + ")";
            return LineGraph;
        }

        public string linearSystem(int complexity, int Intensity)
        {
            try
            {
                Random rd = new Random();
                string Ret = "";
                if (complexity == 2 && Intensity == 1)
                {

                    int x = rd.Next(10);
                    int y = rd.Next(10);

                    int c1 = rd.Next(10);
                    int c2 = rd.Next(10);
                    int c3 = rd.Next(10);
                    int c4 = rd.Next(10);
                    int E1 = 0, E2 = 0;

                    E1 = c1 * (x) + c2 * (y);
                    E2 = c3 * (x) + c4 * (y);
                    Ret = c1.ToString() + "x" + "+" + c2.ToString() + "y =" + E1.ToString() + "\n" + c3.ToString() + "x" + "+" + c4.ToString() + "y =" + E2.ToString();
                }
                if (complexity == 3 && Intensity == 1)
                {
                    int x = rd.Next(10);
                    int y = rd.Next(10);
                    int z = rd.Next(10);

                    int c1 = rd.Next(10);
                    int c2 = rd.Next(10);
                    int c3 = rd.Next(10);
                    int c4 = rd.Next(10);
                    int c5 = rd.Next(10);
                    int c6 = rd.Next(10);
                    int c7 = rd.Next(10);
                    int c8 = rd.Next(10);
                    int c9 = rd.Next(10);
                    int E1 = 0, E2 = 0, E3 = 0;

                    E1 = c1 * (x) + c2 * (y) + c3 * (z);
                    E2 = c4 * (x) + c5 * (y) + c6 * (z);
                    E3 = c7 * (x) + c8 * (y) + c9 * (z);
                    Ret = c1.ToString() + "x" + "+" + c2.ToString() + "y" + "+" + c3.ToString() + "z =" + E1.ToString() + "\n" + c4.ToString() + "x" + "+" + c5.ToString() + "y" + "+" + c6.ToString() + "z =" + E2.ToString() + "\n" + c7.ToString() + "x" + "+" + c8.ToString() + "y" + "+" + c9.ToString() + "z =" + E3.ToString() + "\n";
                }
                return Ret;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public string DiffSqr(int factorSize,int CoeffSize, bool withBracket)
        {
            try
            {
            Random rd = new Random();
            string[] Term = new string[6] { "x", "r", "q", "j", "k", "f" };
            string Var = "";
            string VarIn = "";
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0;
            string Ques = "Simplify by finding the difference of squares in :";
            if (factorSize == 1)
            {

            }

            if (factorSize == 2)
            {
                if (withBracket)
                {
                    c1 = rd.Next(1, 10);
                    c2 = rd.Next(1, 10);
                    c3 = rd.Next(1, 10);
                    c4 = rd.Next(1, 10);
                    c5 = rd.Next(1, 10);
                    c6 = rd.Next(1, 10);
                    Var = Term[rd.Next(0, 5)];
                    VarIn = Term[rd.Next(0, 5)];
                    Ques = Ques + "(" + c1.ToString() + "+" + c2.ToString() + Var + ")" + "+" + "(" + c5.ToString() + "+" + c6.ToString() + VarIn + ")" + "(" + c3.ToString() + "+" + c4.ToString() + Var + ")" + "+" + "(" + c5.ToString() + "+" + c6.ToString() + VarIn + ")";
                }

                if (!withBracket)
                {
                    c1 = rd.Next(1, 10);
                    c2 = rd.Next(1, 10);
                    c3 = rd.Next(1, 10);
                    c4 = rd.Next(1, 10);
                    c5 = rd.Next(1, 10);
                    c6 = rd.Next(1, 10);
                    Var = Term[rd.Next(0, 5)];
                    VarIn = Term[rd.Next(0, 5)];
                    Ques = Ques + "[" + (c1 * c5).ToString() + "+" + (c1 * c6).ToString() + Var + (c2 * c5).ToString() + "+" + (c2 * c6).ToString() + Var + VarIn + "]" + "+" + "[" + (c3 * c5).ToString() + "+" + (c3 * c6).ToString() + Var + (c4 * c5).ToString() + "+" + (c4 * c6).ToString() + Var + VarIn;

                }
            }

            if (factorSize == 3)
            {

            }

            return Ques;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public string ExpoEqs(int complexity)
        {
            try
            {
            Random rd = new Random();
            int eql = 0;
            string Ques = "Solve for possible x in the following equation : ";
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0,c7=0,c8=0,c9=0;
            if (complexity == 2)
            {
                c1 = rd.Next(1, 10);
                c2 = rd.Next(1, 3);
                c3 = rd.Next(1, 3);
                c4 = rd.Next(1, 10);
                c5 = rd.Next(1, 10);
                c6 = rd.Next(1, 10);
                c7 = rd.Next(1, 10);
                c8 = rd.Next(1, 10);
                c9 = rd.Next(1, 10);
                eql = rd.Next(0, 1);

                Ques = Ques + "[" + c1.ToString() + "^(" + c4.ToString() + c5.ToString() + "x" + ")]/" + "[" + (c1 ^ c2).ToString() + "^(" + c6.ToString() + c7.ToString() + "x" + ")] = " + "[" + (c1 ^ c3).ToString() + "^(" + c8.ToString() + c9.ToString() + "x" + ")]";

            }
            return "";
            }
            catch (Exception)
            {
                return "";
            }
        }


    }
}
