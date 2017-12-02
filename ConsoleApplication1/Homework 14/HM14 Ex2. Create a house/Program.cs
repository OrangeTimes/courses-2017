using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM14_Ex2.Create_a_house
{
    class Program
    {

        /*
        2. Create a house using objects like 1 door, 1 window, 4 walls, 1 roof.
        Create few appropriate properties for each object (for window – width, height, glass thickness etc.) and created house based on them.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("   Door 1");                                                 // creating a door
            Door door1 = new Door("KyivDveri", "brown", "wood", 2, true, true, true);
            Console.ReadLine();

            Console.WriteLine("   Door 2");
            Door door2 = new Door("KyivDveri", "green", "wood", 3, false, false, true);
            Console.ReadLine();

            Console.WriteLine("   Door 3");
            Door door3 = new Door("KyivDveri", "black", "plywood", 2, true, true, true);
            Console.ReadLine();



            Console.WriteLine("   Windows");                                                 // creating several windows using lists
			// todo: Here arrays will be sufficient since you are not doing any list specific stuff
			// todo: you should create an actuall house class by passing to it all the needed parts like: new House(Wall[] walls, Window[] windows)
            List<Window> myWindows = new List<Window>()
            {
                new Window(120, 80, "brown", "medium", 2),
                new Window(120, 80, "brown", "medium", 2),
                new Window(120, 80, "brown", "medium", 2),
                new Window(120, 80, "brown", "medium", 2),
                new Window(120, 80, "brown", "medium", 2),
                new Window(120, 80, "brown", "medium", 2),
                new Window(120, 80, "brown", "medium", 2),
                new Window(120, 80, "brown", "medium", 2)
            };
            Console.ReadLine();

            Console.WriteLine("   Walls");                                                   // creating several walls using lists
            List<Wall> myWalls = new List<Wall>()
            {
                new Wall(true, 600, 1000),
                new Wall(true, 600, 1000),
                new Wall(true, 600, 1000),
                new Wall(true, 600, 1000)
            };
            Console.ReadLine();

            Console.WriteLine("   Roof");                                                    // creating roof
            Roof myRoof = new Roof("Tiles", 30, 2, true);
            Console.ReadLine();

            Console.WriteLine("   House is ready");
            Console.ReadLine();
        }
    }
}
