using System;

class Program
{
    static void Main(string[] args)
    {
        Stock myStock = new Stock();
        myStock.ReadFile();

        Console.WriteLine("Welcome to the Inventory Manager Program!");

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
                    Console.Clear();
                    Console.WriteLine("MANAGE INVENTORY");
                    Console.WriteLine("");
                    Console.WriteLine("ITEM LIST:");
                    myStock.ListItems();
                    bool loopBreakInventory = true;
                    while (loopBreakInventory)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Choose one option:");
                        Console.WriteLine("1. Update Item");
                        Console.WriteLine("2. Add New Item");
                        Console.WriteLine("3. Go to Main Menu");
                        string inputInventory = Console.ReadLine();
                        Console.WriteLine("");
                        
                        switch(inputInventory)
                        {
                            case "1":
                                Console.Write("Insert the ID of the item you want to update: ");
                                int updateItem = int.Parse(Console.ReadLine());
                                myStock.UpdateItem(updateItem);
                                break;

                            case "2":
                                
                                break;

                            case "3":
                                Console.WriteLine("Going to Main Menu");
                            //Maybe add an animation here.
                                Thread.Sleep(2000);
                                loopBreakInventory = false;
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("Please enter a valid choice.");
                                break;
                        }
                    }
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("MAKE SALES");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("BUY LIST");
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("SALES REPORT");
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("MANAGE USERS");
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