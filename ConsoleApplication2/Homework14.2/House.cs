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
        public List <Wall> myWalls;

        public House(List <Wall> myWalls, Window myWindow, Door myDoor)
        {
            this.myWalls = myWalls;
            this.myWindow = myWindow;
            this.myDoor = myDoor;     
        }
    }
}
