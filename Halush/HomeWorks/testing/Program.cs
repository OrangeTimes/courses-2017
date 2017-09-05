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
        public void CreateHouse()
        {
            Door myDoor = new Door();
            myDoor.material = "oak";
            myDoor.height = 200;
            myDoor.thickness = 3;
            myDoor.width = 80;
            Window myWindow = new Window();
            myWindow.width = 100;
            myWindow.height = 130;
            myWindow.thickness = 1;
            myWindow.trasparency = 80;
            Wall myLeftSideWall = new LeftSideWall();
            myLeftSideWall.material = "concrete";
            myLeftSideWall.thickness = 20;
            myLeftSideWall.height = 250;
            myLeftSideWall.width = 800;
            Wall myRightSideWall = new RightSideWall();
            myRightSideWall.material = "concrete";
            myRightSideWall.thickness = 20;
            myRightSideWall.height = 250;
            myRightSideWall.width = 800;
            Wall myFrontWall = new FrontWall();
            myRightSideWall.material = "concrete";
            myRightSideWall.thickness = 20;
            myRightSideWall.height = 250;
            myRightSideWall.width = 500;
            Wall myBackWall = new BackWall();
            myRightSideWall.material = "concrete";
            myRightSideWall.thickness = 20;
            myRightSideWall.height = 250;
            myRightSideWall.width = 500;
        }
    }

    public class Door
    {
        public string material = "oak";
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

    public class LeftSideWall : Wall { }

    public class RightSideWall : Wall { }

    public class FrontWall : Wall { }

    public class BackWall : Wall { }

    class Program
    {
        public static void Main()
        {
            House myHouse = new House();
        }
    }
}

