using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleCasting
{
    class MultipleCasting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value to convert: ");
            string valueToConvert = Console.ReadLine();

            Console.WriteLine(@"Enter Type to convert (select between ""byte"", ""short"", ""integer"", ""long""): ");
            string typeToConvert = Console.ReadLine();

            switch (typeToConvert)
            {
                case "byte":
                    Console.WriteLine($"{Convert.ToByte(valueToConvert)}");
                    break;

                case "short":
                    Console.WriteLine($"{Convert.ToInt16(valueToConvert)}");
                    break;

                case "integer":
                    Console.WriteLine($"{Convert.ToInt32(valueToConvert)}");
                    break;

                case "long":
                    Console.WriteLine($"{Convert.ToInt64(valueToConvert)}");
                    break;

                default:
                    Console.WriteLine("Unsupported target type.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
