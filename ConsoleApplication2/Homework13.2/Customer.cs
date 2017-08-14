using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13._2
{
    public class Customer
    {
        public int age;
        public int discount;

        public int CalculateDiscount (int age)
            {
                if (age < 30)
                {
                    discount = 10;
                }
                else if (age >= 30 && age < 50)
                {
                    discount = 20;
                }
                else
                {
                    discount = 30;
                }
                return discount;
            }
        }
    }

