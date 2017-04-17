using System;
namespace CarCatalog
{
    class CarCatalog
    {
        static void Main(string[] args)
        {
            // string customerName, carManufacturer, carModel, finalAnswer;
            // todo: this is a valid statement. But as general rule you should move declarations closer to assingment
            // int carManufacturingYear, carPrice;
            // decimal carCubicCapacity;
            // double carCubicCapacity;
            // todo: in general we use double to store such values
            Console.Write("Please enter your Name:\n");
            string customerName = Console.ReadLine();
            // To increase code readability I would recommend to add empty lines after some logical code end. In this case after ReadLine();

            Console.Write($"{customerName}, please enter car manufacturer:\n");
            string carManufacturer = Console.ReadLine();

            Console.Write($"Enter model of {carManufacturer}:\n");
            string carModel = Console.ReadLine();

            Console.Write($"Enter year of manufacturing for {carManufacturer} {carModel}:\n");
            int carManufacturingYear = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter cubic capacity of {carManufacturer} {carModel}:\n");
            double carCubicCapacity = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter preferable price for {carManufacturer} {carModel} of {carManufacturingYear} year with {carCubicCapacity}L engine:\n");
            int carPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Do you really want {carManufacturer} {carModel} of {carManufacturingYear} year with {carCubicCapacity} engine for {carPrice}?\n");
            while (Console.ReadLine() != "yes")
            {
                Console.WriteLine("О на маєш! You should confirm what you've entered by entering yes");
                Console.ReadLine();
                break;
                //break;
            }
            Console.WriteLine("Great Success!");
            Console.ReadKey();
        }
    }
}



