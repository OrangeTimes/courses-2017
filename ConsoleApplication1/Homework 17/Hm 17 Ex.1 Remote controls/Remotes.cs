using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hm_17_Ex._1_Remote_controls
{
    public interface IRemote                       // Remote Interface with declared methods
    {
        void PoverOn();
        void PoverOff();
        void VolumeUp();
        void VolumeDown();
        void Play();
        void Stop();
    }
    public class Remotes: IRemote              // Remotes class that implements IRemote interface
    {

        public bool isOn;                      // class variables declarations and some assignments;
        public const byte maxVolume = 100;
        public const byte minVolume = 0;
        public byte currentVolume;
        public bool isPlaying;
        public string deviceType;


        public void PoverOn()                 // implementation of PoverOn method
        {
            if (isOn == false)
            {
                isOn = true;
                Console.WriteLine(deviceType + " is turned ON");
            }
            else
                Console.WriteLine(deviceType + " is already turned ON");
        }
        public void PoverOff()                // implementation of PoverOff method
        {
            if (isOn == true)
            {
                isOn = false;
                Console.WriteLine(deviceType + " is turned OFF");
            }
            else
                Console.WriteLine(deviceType + " is already turned OFF");
        }
        public void VolumeUp()                // implementation of VolumeUp method
        {
            if (isOn == true)
            {
                if (currentVolume < maxVolume)
                {
                    currentVolume += 1;
                    Console.WriteLine("Volume: " + currentVolume);
                }
                else if (currentVolume == maxVolume)
                    Console.WriteLine("You've reached maximum volume: " + currentVolume);
            }
            else
                Console.WriteLine("Your " + deviceType + " is TURNED OFF");
            
        }
        public void VolumeDown()             // implementation of VolumeDown method
        {
            if (isOn == true)
            {
                if (currentVolume <= maxVolume && currentVolume > minVolume)
                {
                    currentVolume -= 1;
                    Console.WriteLine("Volume: " + currentVolume);
                }
                else if (currentVolume == minVolume)
                    Console.WriteLine("You've reached minimum volume: " + currentVolume);
            }
            else
                Console.WriteLine("Your " + deviceType + " is TURNED OFF");

        }
        public void Play()                   // implementation of Play method
        {
            if (isOn == true)
            {
                if (isPlaying == false)
                {
                    isPlaying = true;
                    Console.WriteLine(deviceType + " is playing");
                }
                else
                    Console.WriteLine(deviceType + " is already playing");
            }
            else
                Console.WriteLine("Your " + deviceType + " is TURNED OFF");

        }
        public void Stop()                  // implementation of Stop method
        {
            if (isOn == true)
            {
                if (isPlaying == true)
                {
                    isPlaying = false;
                    Console.WriteLine(deviceType + " has stopped playing");
                }
                else
                    Console.WriteLine(deviceType + " has already stopped playing");
            }
            else
                Console.WriteLine("Your " + deviceType + " is TURNED OFF");

        }
    }


    public class TVRemote : Remotes                         // 'TVRemote' class that inherits 'Remotes' class
    {
        public TVRemote()                                   // constructor which has custom 'deviceType' value set
        {
            deviceType = "TV";
        }
    }

    public class BluRayPlayerRemote : Remotes               // 'BluRayPlayerRemote' class that inherits 'Remotes' class
    {                                                       
        public BluRayPlayerRemote()                         // constructor which has custom 'deviceType' value set
        {
            deviceType = "Blu-Ray Player";
        }
    }

    public class StereoReceiverRemote : Remotes             // 'StereoReceiverRemote' class that inherits 'Remotes' class
    {
        public StereoReceiverRemote()                       // constructor which has custom 'deviceType' value set
        {
            deviceType = "Stereo Receiver";
        }
    }

}
