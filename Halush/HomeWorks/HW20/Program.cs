using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Create a method that will output to console content of passed List  
2. Create a method that will remove first element in passed in list and add a new value to the end of list. 
3. Create a generic method that accepts only struct values and displays them to console
*/

namespace HW20
{
    public struct Oleg
    {
        public int firstValue;
        public int secondValue;
    }

    public class Program
    {
        // This method outputs the list of items passed to List
        public static void OutputListToConsole(List<object> someList)
        {
            foreach (object items in someList)
            {
                Console.WriteLine(items.ToString());
            }
        }
        // This method removes first items in a List and add new item to the end of the List
        public static void RemoveAndAddItem(List<object> somelist, object newItem)
        {
            somelist.RemoveAt(0);
            somelist.Add(newItem);
        }
        // This method accepts only structs and output it
        public static void OutputStruct<T>(T someStruct) where T : struct
        {
            Console.WriteLine(someStruct);
        }

        public static void Main()
        {
        }
    }
}
