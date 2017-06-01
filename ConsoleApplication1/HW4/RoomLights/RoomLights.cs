using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLights
{
    class RoomLights
    {
        static void Main(string[] args)
        {
            // int roomLights = 0; // 0000 - lights off

            // to enable light # 1, 3, 5 enter 0001, 0011, 0101 - ?

            int roomLights = 0; // 0000
            Console.WriteLine("Enter # of light you want to enable: ");
            int LightNumber = Convert.ToInt32(Console.ReadLine(), 2);

            roomLights |= LightNumber;

            string lightState = Convert.ToString(roomLights, 2);

            Console.WriteLine($"Light # {lightState} is on ");
            Console.ReadKey();

        }
    }
}
