using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
You are developing postal delivery application write a program to get info of delivery method and display it using enums. (User input can be provided as number)
*/

enum PostDelivery
{
    ByAir,
    BySea,
    ByCar,
    PostToPost,
    PostToHome
}

namespace HW7_1
{
    class HW7_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select postal delivery method:");
            string userInput = Console.ReadLine();
        }
    }
}
