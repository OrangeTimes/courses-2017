using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program that will create a car with few different options (manufacturer, year of manufacture, price those are mandatory).
Create 3 different cars and output it values to console (Hint: you can use a separate method in your class for that).
*/

namespace HW13_2
{
    public class Customer
    {
        public int age;
        public int discount;

        public int GetDiscount(int age)
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
            int userAge = Convert.ToInt32(Console.ReadLine());
            myCustomer.discount = myCustomer.GetDiscount(userAge);
            Console.WriteLine("Congratulations! You dicount is {0}%", myCustomer.discount);
            Console.ReadKey();
        }
    }
}
