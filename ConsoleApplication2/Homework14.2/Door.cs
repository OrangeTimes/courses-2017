using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14._2
{
    public class Door
    {
        public string doorType;
        public int numberOfLocks;

        public Door(string doorType, int numberOfLocks)
        {
            this.doorType = doorType;
            this.numberOfLocks = numberOfLocks;
        }
    }
}
