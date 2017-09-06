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

        public Door myDoor;
        public Window myWindow;
        public Roof myRoof;
        public LeftSideWall myLeftWall;
        public RightSideWall myRightWall;
        public FrontWall myFrontWall;
        public BackWall myBackWall;



        public void CreateHouse()
        {

            myDoor.material = "oak";
            myDoor.height = 200;
            myDoor.thickness = 3;
            myDoor.width = 80;
            myWindow.width = 100;
            myWindow.height = 130;
            myWindow.thickness = 1;
            myWindow.trasparency = 80;
            myRoof.material = "steel";
            myRoof.area = 100;
            myLeftWall.material = "concrete";
            myLeftWall.thickness = 20;
            myLeftWall.height = 250;
            myLeftWall.width = 800;
            myRightWall.material = "concrete";
            myRightWall.thickness = 20;
            myRightWall.height = 250;
            myRightWall.width = 800;
            myFrontWall.material = "concrete";
            myFrontWall.thickness = 20;
            myFrontWall.height = 250;
            myFrontWall.width = 500;
            myBackWall.material = "concrete";
            myBackWall.thickness = 20;
            myBackWall.height = 250;
            myBackWall.width = 500;
        }
    }

    public class Door
    {
        public string material;
        public int height;
        public int thickness;
        public int width;

        public void Show()
        {
            Console.WriteLine("Door parameters are:");
            Console.WriteLine("Material: " + material);
            Console.WriteLine("height: " + height);
            Console.WriteLine("thickness: " + thickness);
            Console.WriteLine("width: " + width);
        }
    }

    public class Window
    {
        public int width;
        public int height;
        public int thickness;
        public int trasparency;

        public void Show()
        {
            Console.WriteLine("Window parameters are:");
            Console.WriteLine("width: " + width);
            Console.WriteLine("height: " + height);
            Console.WriteLine("thickness: " + thickness);
            Console.WriteLine("trasparency: " + trasparency);
        }
    }

    public class Roof
    {
        public string material;
        public int area;

        public void Show()
        {
            Console.WriteLine("Roof parameters are:");
            Console.WriteLine("material: " + material);
            Console.WriteLine("area: " + area);
        }
    }

    public class Wall
    {
        public string material;
        public int thickness;
        public int height;
        public int width;
    }

    public class LeftSideWall : Wall
    {
        public void Show()
        {
            Console.WriteLine("Left wall parameters are:");
            Console.WriteLine("material: " + material);
            Console.WriteLine("thickness: " + thickness);
            Console.WriteLine("height: " + height);
            Console.WriteLine("width: " + width);
        }
    }

    public class RightSideWall : Wall
    {
        public void Show()
        {
            Console.WriteLine("Right wall parameters are:");
            Console.WriteLine("material: " + material);
            Console.WriteLine("thickness: " + thickness);
            Console.WriteLine("height: " + height);
            Console.WriteLine("width: " + width);
        }
    }

    public class FrontWall : Wall
    {
        public void Show()
        {
            Console.WriteLine("Front wall parameters are:");
            Console.WriteLine("material: " + material);
            Console.WriteLine("thickness: " + thickness);
            Console.WriteLine("height: " + height);
            Console.WriteLine("width: " + width);
        }
    }

    public class BackWall : Wall
    {
        public void Show()
        {
            Console.WriteLine("Back wall parameters are:");
            Console.WriteLine("material: " + material);
            Console.WriteLine("thickness: " + thickness);
            Console.WriteLine("height: " + height);
            Console.WriteLine("width: " + width);
        }
    }

    class Program
    {
        public static void Main()
        {
            House myHouse = new House();
            myHouse.CreateHouse();
            myHouse.myDoor.Show();
            myHouse.myWindow.Show();
            myHouse.myRoof.Show();
            myHouse.myLeftWall.Show();
            myHouse.myRightWall.Show();
            myHouse.myFrontWall.Show();
            myHouse.myBackWall.Show();
            Console.ReadKey();
        }
    }
}
