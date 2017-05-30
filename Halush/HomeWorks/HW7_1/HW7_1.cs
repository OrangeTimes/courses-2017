using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
You are developing postal delivery application write a program to get info of delivery method and display it using enums. (User input can be provided as number)
*/



namespace HW7_1
{
    enum PostDelivery     //Declare the enum
    {
        ByAir = 1,
        BySea,
        ByCar,
        PostToPost,
        PostToHome
    }
    public class HW7_1
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Currently we have next delivery methods: ByAir, BySea, ByCar, PostToPost, PostToHome.");
            Console.WriteLine("What delivery method would you like to get info about?:");
            string userInput = Console.ReadLine();
            // Parse a user's input to get a value from enum despite user entered a numeric value or verbal value
            var deliveryInfo = (PostDelivery)Enum.Parse(typeof(PostDelivery), userInput, true); 
            switch (deliveryInfo)
            {
                case PostDelivery.ByAir:
                    {
                        Console.WriteLine("Post deivery by air will cost you 10$ per 1 kg and your parcel will be delivered within 7 days");
                        Console.ReadKey();
                        break;
                    }
                case PostDelivery.BySea:
                    {
                        Console.WriteLine("Post deivery by sea will cost you 1$ per 1 kg and your parcel will be delivered within 45 days");
                        Console.ReadKey();
                        break;
                    }
                case PostDelivery.ByCar:
                    {
                        Console.WriteLine("Post deivery by car will cost you 3$ per 1 kg and your parcel will be delivered within 20 days");
                        Console.ReadKey();
                        break;
                    }
                case PostDelivery.PostToPost:
                    {
                        Console.WriteLine("Delivery cost to your post will depend on a type of transportaion");
                        Console.ReadKey();
                        break;
                    }
                case PostDelivery.PostToHome:
                    {
                        Console.WriteLine("Delivery of your parcel to your home will cost you additional 10$");
                        Console.ReadKey();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("{0} delivery method is not supported", deliveryInfo);
                        Console.ReadKey();
                        break;
                    }
            }
        }
    }
}
