using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create a house using objects like 1 door, 1 window, 4 walls, 1 roof.
Create few appropriate properties for each object (for window – width, height, glass thickness etc.) and created house based on them.
*/

namespace HW14_2
{
    public class House
    {
        public Door myDoor;
        public Window myWindow;
        public Roof myRoof;
        public LeftSideWall myLeftWall;
        public RightSideWall myRightWall;
        public FrontWall myFrontWall;
        public BackWall myBackWall;

        public House()
        {
            myDoor = new Door();
            myWindow = new Window();
            myRoof = new Roof();
            myLeftWall = new LeftSideWall();
            myRightWall = new RightSideWall();
            myFrontWall = new FrontWall();
            myBackWall = new BackWall();
        }
    }

    public class Door
    {
        public string Material;
        public int Height;
        public int Thickness;
        public int Width;

        public void Show()
        {
            Console.WriteLine("Door parameters are:");
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("height: " + Height);
            Console.WriteLine("thickness: " + Thickness);
            Console.WriteLine("width: " + Width);
        }
    }

    public class Window
    {
        public int Width;
        public int Height;
        public int Thickness;
        public int Trasparency;

        public void Show()
        {
            Console.WriteLine("Window parameters are:");
            Console.WriteLine("width: " + Width);
            Console.WriteLine("height: " + Height);
            Console.WriteLine("thickness: " + Thickness);
            Console.WriteLine("trasparency: " + Trasparency);
        }
    }

    public class Roof
    {
        public string Material;
        public int Area;

        public void Show()
        {
            Console.WriteLine("Roof parameters are:");
            Console.WriteLine("material: " + Material);
            Console.WriteLine("area: " + Area);
        }
    }

    public abstract class Wall
    {
        public string Material;
        public int Thickness;
        public int Height;
        public int Width;

        public abstract string GetWallName();

        public void Show()
        {
            Console.WriteLine(GetWallName() + " wall parameters are:");
            Console.WriteLine("material: " + Material);
            Console.WriteLine("thickness: " + Thickness);
            Console.WriteLine("height: " + Height);
            Console.WriteLine("width: " + Width);
        }
    }

    public class LeftSideWall : Wall
    {
        public override string GetWallName()
        {
            return "Left";
        }
    }

    public class RightSideWall : Wall
    {
        public override string GetWallName()
        {
            return "Right";
        }

    }

    public class FrontWall : Wall
    {
        public override string GetWallName()
        {
            return "Front";
        }

    }

    public class BackWall : Wall
    {
        public override string GetWallName()
        {
            return "Back";
        }

    }

    class Program
    {
        public static void Main()
        {
            House myHouse = new House();
        }
    }
}
