using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_Postal_Delivery_app
{
    enum deliveryMethod
    {
        First_class_mail,
        Second_class_mail,
        Third_class_mail,
        Forth_class_mail,
        Priority_mail,
        Express_mail,
        Certified_mail,
        Return_to_recipient,
        Registered_mail,
        Overnight_delivery
    }

    class Program
    {
        // You are developing postal delivery application
        // write a program to get info of delivery method and
        // display it using enums. (User input can be provided as number)       

        static void Main(string[] args)
        {

            Console.Write("Choose postal delivery method (from 0 to 9): ");
            // from 0 to 9 - because enum's items are indexed from 0
            deliveryMethod userInput = (deliveryMethod)Convert.ToInt32(Console.ReadLine());
            // I create a variable "userInput" of enum type - "deliveryMethod"
            // Receive user input, convert it to int (as ReadLine returns string), ad cast it to enum type - "deliveryMethod" (int that was returned is treated like index of certain element of enum)
            Console.Write($"Your delivery method is {userInput}");
            // Returns variable value to console
            Console.ReadLine();

        }
    }
}
