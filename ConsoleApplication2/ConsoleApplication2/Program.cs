using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare string array and call method to get info about car in string array
            string[] carInfoStrings = new string[4];
            string[] carInfo = GetInfoAboutCar(carInfoStrings);

            //call method to get confirmation message and print it
            string result = ConfirmInfoAboutCar(carInfo);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        // method to get all rquired information about car and put it into string array
        static string[] GetInfoAboutCar (string[] carInfoStrings)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Please specify the manufacturer of the car you'd like to buy:");
                carInfoStrings[0] = Console.ReadLine();

                Console.Write("Please select the model of the car: ");
               carInfoStrings[1] = Console.ReadLine();

                Console.Write("Please specify the year of production: ");
                carInfoStrings[2] = Console.ReadLine();

                Console.Write("Specify the maximum suitable price in dollars: ");
                carInfoStrings[3] = Console.ReadLine();
            }   

        return carInfoStrings;
    }

        //method to print confirmation message about car using string array with car info
        static string ConfirmInfoAboutCar(string[] carInfoStrings)
        {
            string confirmationMessage = $"Please confirm: You'd like to buy {carInfoStrings[0]} {carInfoStrings[1]}, year: {carInfoStrings[2]}, for {carInfoStrings[3]}.";
            return confirmationMessage;
        }
    }
}
