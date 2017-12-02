using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14._2
{
    public class Door
    {
        public string doorType; // todo: in production code you should never exposes you fields as public, they should be private. Use public properties to expose them if needed
        public int numberOfLocks;

        public Door(string doorType, int numberOfLocks)
        {
            this.doorType = doorType;
            this.numberOfLocks = numberOfLocks;
        }
    }
}
