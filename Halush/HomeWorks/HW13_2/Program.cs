using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program to create Customer object from console input and calculate discount based on customer age: below 30 –10%, 30 and below 50 – 20%, 50 and above  - 30%;
*/

namespace HW13_2
{
    public class Customer
    {
        public int age;

        public int GetDiscount()
        {
            int discount = 0;
            if (age < 30)
                discount = -10;
            if (age >= 30 & age <= 49)
                discount = -20;
            else if (age >= 50)
                discount = -30;
            return discount;
        }
    }

    class Program
    {
        public static void Main()
        {
            Customer myCustomer = new Customer();
            Console.WriteLine("Please enter your age to get the discount:");
            myCustomer.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Congratulations! You dicount is {0}%", myCustomer.GetDiscount());
            Console.ReadKey();
        }
    }
}
