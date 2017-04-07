using System;
namespace CarCatalog
{
    class CarCatalog
    {
        static void Main(string[] args)
        {
            string customerName, carManufacturer, carModel, finalAnswer;
            int carManufacturingYear, carPrice;
            decimal carCubicCapacity;
            Console.Write("Please enter your Name:\n");
            customerName = Console.ReadLine();
            Console.Write($"{customerName}, please enter car manufacturer:\n");
            carManufacturer = Console.ReadLine();
            Console.Write($"Enter model of {carManufacturer}:\n");
            carModel = Console.ReadLine();
            Console.Write($"Enter year of manufacturing for {carManufacturer} {carModel}:\n");
            carManufacturingYear = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter cubic capacity of {carManufacturer} {carModel}:\n");
            carCubicCapacity = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"Enter preferable price for {carManufacturer} {carModel} of {carManufacturingYear} year with {carCubicCapacity}L engine:\n");
            carPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Do you really want {carManufacturer} {carModel} of {carManufacturingYear} year with {carCubicCapacity} engine for {carPrice}?\n");
            finalAnswer = Console.ReadLine();
            while (finalAnswer != "yes")
            {
                Console.WriteLine("О на маєш! You should confirm what you've entered by entering yes");
                Console.ReadLine();
                //break;

            }
            Console.WriteLine("Great Success!");
            Console.ReadKey();
        }
    }
}



