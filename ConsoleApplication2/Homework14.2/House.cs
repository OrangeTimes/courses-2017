using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14._2
{
    public class House
    {
        public Door myDoor;
        public Window myWindow;
        public Wall myWall;

        public House(Wall myWall, int numberOfWalls, Window myWindow, int numberOfWindows, Door myDoor)
        {
            this.myWall = myWall;
            this.myWindow = myWindow;
            this.myDoor = myDoor;

        }
    }
}
