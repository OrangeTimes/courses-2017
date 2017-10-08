using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_15_Ex._1_Basic_math_operations
{
    static class MathOperations
    {

        public static double result;

        /// <summary>
        /// Consecutive adds all taken parameters
        /// </summary>
        /// <param name="valuesToAdd"></param>
        /// <returns></returns>
        public static double Add(params double [] valuesToAdd)
        {
            for (int i = 0; i < valuesToAdd.Length; i++)
            {
                result += valuesToAdd[i];
            }
            return result;
        }

        /// <summary>
        /// Takes up arguments and starting from first one consecutivelly subtracts the next params value. 
        /// </summary>
        /// <param name="valuesToSubtract"></param>
        /// <returns>
        /// Returns result of subtraction (Eg. for params - 10,5,2 - result is 3)
        /// </returns>
        public static double Subtract(params double[] valuesToSubtract)
        {
            result = valuesToSubtract[0];
            for (int i = 0; i < valuesToSubtract.Length-1; i++)
            {
                result = result - valuesToSubtract[i + 1];
            }
            return result;
        }

        /// <summary>
        /// One by one multiplies all taken parameters
        /// </summary>
        /// <param name="valuesToMultiply"></param>
        /// <returns></returns>
        public static double Multiply(params double[] valuesToMultiply)
        {
            result = 1;
            for (int i = 0; i < valuesToMultiply.Length; i++)
            result = result* valuesToMultiply[i];
            return result;
        }
        /// <summary>
        /// Takes up arguments and starting from first one consecutivelly divides by the next param value. 
        /// </summary>
        /// <param name="valuesToDivide"></param>
        /// <returns></returns>
        public static double Divide(params double[] valuesToDivide)
        {
            result = valuesToDivide[0];
            for (int i = 0; i < valuesToDivide.Length-1; i++)
            {
                result /= valuesToDivide[i + 1];
            }
            return result;
        }

    }
}
