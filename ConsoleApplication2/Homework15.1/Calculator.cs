using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15._1
{
    static class Calculator
    {
        public static double result;

        static public double Add(params double[] myDoubles)
        {
            for (int i = 0; i < myDoubles.Length; i++)
            {
                result += myDoubles[i];
            }
            return result;
        }

        static public double Substract(params double[] myDoubles)
        {
            for (int i = 0; i < myDoubles.Length - 1; i++)
            {
                result = myDoubles[i] - myDoubles[i + 1];
            }
            return result;
        }

        static public double Multiply(params double[] myDoubles)
        {
            for (int i = 0; i < myDoubles.Length - 1; i++)
            {
                result = myDoubles[i] * myDoubles[i + 1];
            }
            return result;
        }

        static public double Divide(params double[] myDoubles)
        {
            for (int i = 0; i < myDoubles.Length - 1; i++)
            {
                result = myDoubles[i] / myDoubles[i + 1];
            }
            return result;
        }

    }



}
