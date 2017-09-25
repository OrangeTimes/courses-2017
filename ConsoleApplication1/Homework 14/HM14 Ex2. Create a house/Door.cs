using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM14_Ex2.Create_a_house
{
    class Door                           
    {    
        string manufacturer;          // class variables
        string color;
        string material;
        int numberOfHinges;
        bool isWithGlass;
        bool isRightSideOpened;
        bool isInvardsOpened;

        public Door(string manufacturer)                // here and below in this class are differnt constructors with different number of parameters
        {
            this.manufacturer = manufacturer;
            Console.WriteLine("Door Manufasturer = " + manufacturer);  //  to print out what was created and with what attributes
        }

        public Door(string manufacturer, string color)
        {
            this.manufacturer = manufacturer;
            this.color = color;
            Console.WriteLine("Door Manufasturer = " + manufacturer + '\n' + "Door color = " + color);
        }

        public Door(string manufacturer, string color, string material)
        {
            this.manufacturer = manufacturer;
            this.color = color;
            this.material = material;
            Console.WriteLine("Door Manufasturer = " + manufacturer + '\n' + "Door color = " + color + '\n' + "Door material = " + material);
        }

        public Door(string manufacturer, string color, string material, int numberOfHinges)
        {
            this.manufacturer = manufacturer;
            this.color = color;
            this.material = material;
            this.numberOfHinges = numberOfHinges;
            Console.WriteLine("Door Manufasturer = " + manufacturer + '\n' + "Door color = " + color + '\n' + "Door material = " + material + '\n' + "Number of hinges = ");
        }

        public Door(string manufacturer, string color = "brown", string material = "wood", int numberOfHinges = 3, bool isWithGlass = false, bool isRightSideOpened = true, bool isInvardsOpened = false)
        {
            this.manufacturer = manufacturer;
            this.color = color;
            this.material = material;
            this.numberOfHinges = numberOfHinges;
            this.isWithGlass = isWithGlass;
            this.isRightSideOpened = isRightSideOpened;
            this.isInvardsOpened = isInvardsOpened;
            Console.WriteLine("Door Manufasturer = " + manufacturer + '\n' + "Door color = " + color + '\n' + "Door material = " + material + '\n' + "Number of hinges = " + '\n' + "Is door with glass = " + isWithGlass + '\n' + "Is door right side opened = " + isRightSideOpened + '\n' + "Is door invards opened = " + isInvardsOpened);
        }
    }

    class Window
    {
        string color;
        string glassThickness;
        int height;
        int width;
        int numberOfGlasses;

        public Window(string color, int height, int width)
        {
            this.color = color;
            this.height = height;
            this.width = width;
            Console.WriteLine("Window color = " + color + '\n' + "Window height = " + height + '\n' + "Window width = " + width + '\n');
        }
        public Window(int height, int width, string color = "white", string glassThickness = "medium", int numberOfGlasses = 3)
        {
            this.color = color;
            this.glassThickness = glassThickness;
            this.height = height;
            this.width = width;
            this.numberOfGlasses = numberOfGlasses;
            Console.WriteLine("Window color = " + color + '\n' + "Glass thickness = " + glassThickness + '\n' + "Window height = " + height + '\n' + "Window width = " + width + '\n' + "Number of glasses = " + numberOfGlasses + '\n');
        }
    }

    class Wall
    {
        bool isBrickWall;
        int wallHeight;
        int wallWidth;

        public Wall(bool isBrickWall, int wallHeight, int wallWidth)
        {
            this.isBrickWall = isBrickWall;
            this.wallHeight = wallHeight;
            this.wallWidth = wallWidth;
            Console.WriteLine("Is Brick wall = " + isBrickWall + '\n' + "Wall height = " + wallHeight + '\n' + "Wall width = " + wallWidth + '\n');
        }
    }

    class Roof
    {
        string roofMaterial;
        int roofAngle;
        int roofSides;
        bool isRoofWithWindow;

        public Roof(string roofMaterial, int roofAngle, int roofSides, bool isRoofWithWindow)
        {
            this.roofMaterial = roofMaterial;
            this.roofAngle = roofAngle;
            this.roofSides = roofSides;
            this.isRoofWithWindow = isRoofWithWindow;
            Console.WriteLine("Roof Material = " + roofMaterial + '\n' + "Roof Angle = " + roofAngle + '\n' + "Roof Sides = " + roofSides + '\n' + "Is Roof With Window = " + isRoofWithWindow);
        }
    }

}
