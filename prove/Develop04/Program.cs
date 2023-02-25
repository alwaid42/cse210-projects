using System;

class Program
{
    static void Main(string[] args)
    {
        bool loopBreak = true;
        while (loopBreak)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choiche from the menu: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    BreathingActivity myBreathing = new BreathingActivity();
                    myBreathing.DisplayStart();
                    myBreathing.RunActivity();
                    myBreathing.DisplayFinish();
                    break;

                case "2":
                    ReflectingActivity myReflecting = new ReflectingActivity();
                    myReflecting.DisplayStart();
                    myReflecting.RunActivity();
                    myReflecting.DisplayFinish();
                    break;

                case "3":
                    ListingActivity myListing = new ListingActivity();
                    myListing.DisplayStart();
                    myListing.RunActivity();
                    myListing.DisplayFinish();
                    break;

                case "4":
                    loopBreak = false;
                    break;

                default:
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine(" ");
                    break;
            }
        }
    }
}