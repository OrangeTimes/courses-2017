using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM13_Ex._2_Calculate_Discount
{
    class Program
    {
        /*
        2. Write a program to create Customer object from console input 
        and calculate discount based on customer age: 
        below 30         – 10%, 
        30 and below 50  – 20%, 
        50 and above     – 30%;
        */

        static void Main(string[] args)
        {
            
            Customer Vita = new Customer(25);  // creating new object of class Customer

            Console.WriteLine("Your discount = " + Vita.discount); // printing discount info
            Console.ReadLine();
        }
    }
}
