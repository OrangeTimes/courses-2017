using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Write a program to create Customer object from console input and calculate discount 
            //based on customer age: 
            //below 30 –10%, 30 and below 50 – 20%, 50 and above  - 30%;

            //get age info
            Console.Write("please enter the age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // create new object of class Customer
            Customer Vita = new Customer(); // todo: you shold pass entered age from console to contructor instead
            
            // print discount info
            Console.WriteLine($"Your discount = {Vita.CalculateDiscount(age)}%");
            Console.ReadLine();
        }

        
    }
}
