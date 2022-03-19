using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3__matrix_calculator_
{
    class FunctionHandler
    {

        public static int[] ParseInput(String quadEquetion)
        {

            String a = "";
            String b = "";
            String c = "";
            bool aParse = true;
            bool bParse = false;
            bool cParse = false;

            // Parse a,b,c
            foreach (char num in quadEquetion)
            {

                // parse a
                if (aParse)
                {
                    if ((num.ToString().Equals("-")) || (num.ToString().Equals("+")))
                    {
                        aParse = false;
                        bParse = true;
                        continue;
                    }
                    else
                        a = a + num;
                }


                // parse b

                if (bParse)
                {

                    if ((num.ToString().Equals("-")) || (num.ToString().Equals("+")))
                    {
                        bParse = false;
                        cParse = true;
                        continue;

                    }
                    else
                        b = b + num;
                }


                // parse c

                if (cParse)
                {
                    if (num.ToString().Equals("="))
                        break;
                    c = c + num;
                }

            }

            a = a.Remove(a.Length - 3);
            b = b.Remove(a.Length);


            int a_num = Int32.Parse(a);
            int b_num = Int32.Parse(b);
            int c_num = Int32.Parse(c);
            int[] args = { a_num, b_num, c_num };

            return args;
        }

        public static String SolveQuad(int a, int b, int c)
        {

            double x1 = ((-1) * b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = ((-1) * b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

            return ("x1=" + x1.ToString() + ", x2=" + x2.ToString());
        }
    }
}
