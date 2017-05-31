using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7._1
{
    class Program
    {
        enum DeliveryMethods
        {
            Express,
            Free_Shipping,
            General_Delivery,
            Recorded_Delivery,
            Reply_Paid_Delivery,
            Special_Delivery
        }
        static void Main(string[] args)
        {
            /* 1.You are developing postal delivery application write a program to get info of delivery method and display it using enums. (User input can be provided as number)*/
                      
            Console.Write("Please choose the preferred delivery method: ");
            DeliveryMethods userInput = (DeliveryMethods)Convert.ToInt32(Console.ReadLine());
            
            Console.Write($"You have chosen {userInput}");
            Console.ReadLine();


    }
    }
}
