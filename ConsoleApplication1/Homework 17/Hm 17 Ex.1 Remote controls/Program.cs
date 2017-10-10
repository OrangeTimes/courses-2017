using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hm_17_Ex._1_Remote_controls
{
    class Program
    {

        /*
        1. Create an application that can use Remote (IRemote interface) to control TV, Blu-Ray player, and Stereo Receiver.  
        The buttons on remote are: Power On, Power Off, Volume Up (max 100%), Volume Down (min 0%), Play, and Stop. 
        Each device should show its message after corresponding action. 
        Use any keyboard binding on your choice as in Exercise 16 to emulate remote using your keyboard via console. 
        You can use 1, 2, 3 keyboard keys to select device type.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type of remote:" +'\n'+ "1 for TV remote" + '\n' + "2 for Blu-Ray player remote" + '\n' 
                + "3 for Stereo Receiver remote" + '\n' + "by default is used TV remote" + '\n');
            int remoteType = Convert.ToInt32(Console.ReadLine());
            Remotes myRemote;
            switch (remoteType)               // switch for creating certain remote based on user input
            {
                case 1:
                    myRemote = new TVRemote();
                    break;

                case 2:
                    myRemote = new BluRayPlayerRemote();
                    break;

                case 3:
                    myRemote = new StereoReceiverRemote();
                    break;

                default:
                    myRemote = new TVRemote();
                    break;

            }
            Console.WriteLine("Now you can operate your chosen remote" + '\n' + "Use 'O' key to turn on your device" + '\n' 
                + "Use 'F' key to turn off your device" + '\n' + "Use 'Up Arrow' key to turn Volume Up" + '\n' 
                + "Use 'Down Arrow' key to turn Volume Down" + '\n' + "Use 'P' key to play" + '\n' + "Use 'S' key to stop playing");

            int x = 1;
            while (x == 1)    // while loop  - for making possible continuous user input
            {
                ConsoleKey pressedKey = Console.ReadKey().Key;
                Console.WriteLine();

                switch (pressedKey)   // switch for key binding to a method
                {
                    case ConsoleKey.O:
                        myRemote.PoverOn();
                        break;
                    case ConsoleKey.F:
                        myRemote.PoverOff();
                        break;
                    case ConsoleKey.UpArrow:
                        myRemote.VolumeUp();
                        break;
                    case ConsoleKey.DownArrow:
                        myRemote.VolumeDown();
                        break;
                    case ConsoleKey.P:
                        myRemote.Play();
                        break;
                    case ConsoleKey.S:
                        myRemote.Stop();
                        break;
                }
            }
        }   
    }
}
