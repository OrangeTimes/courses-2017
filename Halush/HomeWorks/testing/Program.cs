using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


/*
Create a house using objects like 1 door, 1 window, 4 walls, 1 roof. 
Create few appropriate properties for each object (for window – width, height, glass thickness etc.) and created house based on them. 
*/


namespace testing
{
    public class House
    {

    }

    public class Door
    {
        public string material;
        public int height;
        public int thickness;
        public int width;
    }

    public class Window
    {
        public int width;
        public int height;
        public int thickness;
        public int trasparency;
    }

    public class Wall
    {
        public string material;
        public int thickness;
        public int height;
        public int width;
    }

    public class LeftSideWall : Wall
    { }

    public class RightSideWall : Wall
    { }

    public class FrontWall : Wall
    { }

    public class BackWall : Wall
    { }

    class Program
    {
        public static void Main()
        {

        }
    }
}

