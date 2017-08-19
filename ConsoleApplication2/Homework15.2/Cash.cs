using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15._2
{
    class Cash
    {
        private double cashSum;
        private double salary;
        // private constructor
        private Cash(double salary, double cashSum)
        {
            cashSum += salary;
        }
        // static method that creates new object of a class
        public static Cash Create (double salary, double cashSum)
        {
            return new Cash(salary, cashSum);
        }
    }
}
