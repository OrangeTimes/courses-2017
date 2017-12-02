using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Create a house using objects like 1 door, 1 window, 4 walls, 1 roof. 
            //Create few appropriate properties for each object 
            //(for window – width, height, glass thickness etc.) and created house based on them.

            // create collection of walls
            List<Wall> myWalls = new List<Wall>() // todo: use of array would be sufficient in current case since you are not perfomening any list specific operations
            {
                new Wall("candy", 4),
                new Wall("candy", 4),
                new Wall("candy", 4),
                new Wall("candy", 4)
            };
            
            // build house
            House myHome = new House(
                myWalls, 
                new Window("oldstyle", 1), 
                new Door("wooden", 2)
                );

           }
    }
}
