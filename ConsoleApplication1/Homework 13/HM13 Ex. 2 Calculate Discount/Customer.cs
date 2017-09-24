using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM13_Ex._2_Calculate_Discount
{
    class Customer
    {
            public int age;
            public int discount;
        public Customer(int age) // using custom constructor that takes age as a parameter
        {
            if (age < 30)                         // discount logic
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

            this.age = age;    // referencing class variable "age" to a constructor parameter "age"
        }
           


    }
}
