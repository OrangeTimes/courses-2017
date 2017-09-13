using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create an application that can use Remote (IRemote interface) to control TV, Blu-Ray player, and Stereo Receiver.
The buttons on remote are: Power On, Power Off, Volume Up (max 100%), Volume Down (min 0%), Play, and Stop. 
Each device should show its message after corresponding action. 
Use any keyboard binding on your choice as in Exercise 16 to emulate remote using your keyboard via console. 
You can use 1, 2, 3 keyboard keys to select device type.
*/


namespace HW17
{
    interface IRemote
    {
        bool PowerOn();
        bool PowerOff();
        bool Play();
        bool Stop();
        int VolumeUp();
        int VolumeDown();
    }

    public class Receiver : IRemote
    {
        public string type;
        public int volumePercent;
        bool isReceiverOn = false;
        bool IsReceiverPlaying = false;

        public Receiver()
        {
            type = "Receiver";
            volumePercent = 0;
        }

        //This method verifies whether the receiver is not turned on yet and if it's not - turns it on
        public bool PowerOn()
        {
            if (isReceiverOn == false)
            {
                Console.WriteLine("{0} is turned on.", type);
                isReceiverOn = true;
            }
            else
                Console.WriteLine("Your receiver is already turned on.");
            return isReceiverOn;
        }
        //This method verifies whether the receiver is not turned off yet and if it's not - turns it off
        public bool PowerOff()
        {
            if (isReceiverOn == true)
            {
                Console.WriteLine("{0} is turned off.", type);
                isReceiverOn = false;
            }
            else
                Console.WriteLine("Your receiver is already turned off.");
            return isReceiverOn;
        }
        //This method verifies whether the receiver is not turned on or playing already and if it's not - it doesn't allow to make it playing 
        public bool Play()
        {
            if (isReceiverOn == true)
            {
                if (IsReceiverPlaying == false)
                {
                    Console.WriteLine("Play.");
                    IsReceiverPlaying = true;
                }
                else
                    Console.WriteLine("Your receiver is already playing.");
            }
            else
                Console.WriteLine("Your receiver is not turned on yet.");
            return IsReceiverPlaying;
        }
        //This method verifies whether the receiver is not turned off or stopped already and if it's not - it doesn't allow to stop it
        public bool Stop()
        {
            if (isReceiverOn == true)
            {
                if (IsReceiverPlaying == true)
                {
                    Console.WriteLine("Stop.");
                    IsReceiverPlaying = false;
                }
                else
                    Console.WriteLine("Your receiver is not playing already.");
            }
            else
                Console.WriteLine("Your receiver is not turned on yet.");
            return IsReceiverPlaying;
        }
        //This method verifies whether receiver is turned on and playing and if it's not - it doesn't allow to manage the the volume
        public int VolumeUp()
        {
            if (isReceiverOn == true)
            {
                if (IsReceiverPlaying == true)
                {
                    if (volumePercent >= 0 & volumePercent < 100)
                    {
                        volumePercent += 10;
                        Console.WriteLine("Volume is increased. It is {0} percent.", volumePercent);
                    }
                    else
                        Console.WriteLine("Current volume percent is {0}. You can't make it louder.", volumePercent);
                }
                else
                    Console.WriteLine("Your receiver is not playing yet.");
            }
            else
                Console.WriteLine("Your receiver is not turned on yet.");
            return volumePercent;
        }
        //This method verifies whether receiver is turned on and playing and if it's not - it doesn't allow to manage the the volume
        public int VolumeDown()
        {
            if (isReceiverOn == true)
            {
                if (IsReceiverPlaying == true)
                {
                    if (volumePercent > 0)
                    {
                        volumePercent -= 10;
                        Console.WriteLine("Volume is decreased. It is {0} percent.", volumePercent);
                    }
                    else
                        Console.WriteLine("Current volume percent is {0}. You can't make it quieter.", volumePercent);
                }
                else
                    Console.WriteLine("Your receiver is not playing yet.");
            }
            else
                Console.WriteLine("Your receiver is not turned on yet.");
            return volumePercent;
        }

        
    }

    public class TV : Receiver
    {
        public TV()
        {
            type = "TV";
        }
    }

    public class BluRay : Receiver
    {
        public BluRay()
        {
            type = "BluRay";
        }
    }

    public class Stereo : Receiver
    {
        public Stereo()
        {
            type = "Stereo";
        }
    }

    class Program
    {

        static void Instruction()
        {
            Console.WriteLine("Press 1 to power on, 2 to power off, 3 to increase a volume, 4 to decrease a volume, 5 to play, 6 to stop, Esc to exit the program.");
        }
        //This method verifies whether user has entered an int and whether it is 1 or 2 or 3 and if it's not - it asks him to enter a proper value
        //Based on the entered value it creates a corresponding receiver's type
        static Receiver ChooseYourReceiver()
        {
            Console.WriteLine("Please choose your receiver:");
            Console.WriteLine("Press 1 for RV. Press 2 for BluRay. Press 3 for Stereo.");
            bool isUserInputValid = Int32.TryParse(Console.ReadLine(), out int usersInput);
            while (!isUserInputValid || (usersInput !=1 && usersInput != 2 && usersInput != 3))
            {
                Console.WriteLine("You have entered an incorrect value. Please try again.");
                Console.WriteLine("Press 1 for RV. Press 2 for BluRay. Press 3 for Stereo.");
                isUserInputValid = Int32.TryParse(Console.ReadLine(), out usersInput);
            }

            Receiver newReceiver;

            switch (usersInput)
            {
                case 1:
                    {
                        newReceiver = new TV();
                        Console.WriteLine("You are using a {0} receiver.", newReceiver.type);
                        Instruction();
                        break;
                    }
                case 2:
                    {
                        newReceiver = new BluRay();
                        Console.WriteLine("You are using a {0} receiver.", newReceiver.type);
                        Instruction();
                        break;
                    }
                case 3:
                    {
                        newReceiver = new Stereo();
                        Console.WriteLine("You are using a {0} receiver.", newReceiver.type);
                        Instruction();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You haven't chosen proposed receiver. The default one will be created.");
                        Instruction();
                        newReceiver = new Receiver();
                        break;
                    }
            }
            return newReceiver;
        }

        public static void Main()
        {
            Receiver newReceiver = ChooseYourReceiver();

            int i = 1;
            while (i > 0)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.WriteLine();
                            newReceiver.PowerOn();
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            Console.WriteLine();
                            newReceiver.PowerOff();
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            Console.WriteLine();
                            newReceiver.VolumeUp();
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            Console.WriteLine();
                            newReceiver.VolumeDown();
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            Console.WriteLine();
                            newReceiver.Play();
                            break;
                        }
                    case ConsoleKey.D6:
                        {
                            Console.WriteLine();
                            newReceiver.Stop();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            i = 0;
                            break;
                        }
                }
            }
        }
    }
}
