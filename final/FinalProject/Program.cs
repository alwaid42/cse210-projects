using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Inventory Management Program!");

        bool loopBreak=true;
        while (loopBreak)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Manage Inventory");
            Console.WriteLine("2. Make Sales");
            Console.WriteLine("3. Buy list");
            Console.WriteLine("4. Sales Report");
            Console.WriteLine("5. Manage Users");
            Console.WriteLine("6. Quit");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    loopBreak = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice.");
                    break;
            }
        }
    }
}