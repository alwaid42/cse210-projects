using System;

class Program
{
    static void Main(string[] args)
    {
        Stock myStock = new Stock();
        myStock.ReadFile();

        UserBase myUsers = new UserBase();
        myUsers.ReadUsers();

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
                    
                    bool loopBreakInventory = true;
                    while (loopBreakInventory)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Choose one option:");
                        Console.WriteLine("1. List Items");
                        Console.WriteLine("2. Update Item");
                        Console.WriteLine("3. Add New Item");
                        Console.WriteLine("4. Go to Main Menu");
                        string inputInventory = Console.ReadLine();
                        Console.WriteLine("");
                        
                        switch(inputInventory)
                        {
                            case "1":
                                Console.WriteLine("ITEM LIST:");
                                Console.WriteLine("");
                                myStock.ListItems();
                                Console.WriteLine("");
                                break;

                            case "2":
                                Console.Write("Insert the ID of the item you want to update: ");
                                int updateItem = int.Parse(Console.ReadLine());
                                myStock.UpdateItem(updateItem);
                                myStock.SaveFile();
                                break;

                            case "3":
                                Console.WriteLine("Which Type of item you want to add? ");
                                Console.WriteLine("1. Volume Item");
                                Console.WriteLine("2. Length Item");
                                Console.WriteLine("3. Weight Item");
                                Console.WriteLine("4. Unit Item");
                                string addItem = Console.ReadLine();

                                switch (addItem)
                                {

                                    case "1":
                                        Console.WriteLine("1. Volume Item");
                                        Console.WriteLine("");
                                        //still working on how to fix id attribute. Probably just going to delete it
                                        //string newIDV = "XXXXX";
                                        Console.Write("Name: ");
                                        string newNameV = Console.ReadLine();
                                        Console.Write("Description: ");
                                        string newDescriptionV = Console.ReadLine();
                                        Console.Write("Volume in Stock: ");
                                        float newVolume = float.Parse(Console.ReadLine());
                                        Console.Write("Minimum volume:");
                                        float newMinimumV = float.Parse(Console.ReadLine());
                                        Console.Write("Price Paid: ");
                                        float newPaidV = float.Parse(Console.ReadLine());
                                        Console.Write("Sell Price: ");
                                        float newSellV = float.Parse(Console.ReadLine());

                                        Volume newItemV = new Volume(newNameV, newDescriptionV, newVolume, newMinimumV, newPaidV, newSellV);

                                        myStock.AddItem(newItemV);

                                        break;
                                        
                                    case "2":
                                        Console.WriteLine("2. Length Item");
                                        Console.WriteLine("");
                                        //still working on how to fix id attribute. Probably just going to delete it
                                        //string newIDL = "XXXXX";
                                        Console.Write("Name: ");
                                        string newNameL = Console.ReadLine();
                                        Console.Write("Description: ");
                                        string newDescriptionL = Console.ReadLine();
                                        Console.Write("Length in Stock: ");
                                        float newLength = float.Parse(Console.ReadLine());
                                        Console.Write("Minimum Length:");
                                        float newMinimumL = float.Parse(Console.ReadLine());
                                        Console.Write("Price Paid: ");
                                        float newPaidL = float.Parse(Console.ReadLine());
                                        Console.Write("Sell Price: ");
                                        float newSellL = float.Parse(Console.ReadLine());

                                        Length newItemL = new Length(newNameL, newDescriptionL, newLength, newMinimumL, newPaidL, newSellL);

                                        myStock.AddItem(newItemL);

                                        break;

                                    case "3":
                                        Console.WriteLine("3. Weight Item");
                                        Console.WriteLine("");
                                        //still working on how to fix id attribute. Probably just going to delete it
                                        //string newIDW = "XXXXX";
                                        Console.Write("Name: ");
                                        string newNameW = Console.ReadLine();
                                        Console.Write("Description: ");
                                        string newDescriptionW = Console.ReadLine();
                                        Console.Write("Weight in Stock: ");
                                        float newWeight = float.Parse(Console.ReadLine());
                                        Console.Write("Minimum Weight:");
                                        float newMinimumW = float.Parse(Console.ReadLine());
                                        Console.Write("Price Paid: ");
                                        float newPaidW = float.Parse(Console.ReadLine());
                                        Console.Write("Sell Price: ");
                                        float newSellW = float.Parse(Console.ReadLine());

                                        Weight newItemW = new Weight(newNameW, newDescriptionW, newWeight, newMinimumW, newPaidW, newSellW);

                                        myStock.AddItem(newItemW);

                                        break;

                                    case "4":
                                        Console.WriteLine("4. Unit Item");
                                        Console.WriteLine("");
                                        //still working on how to fix id attribute. Probably just going to delete it
                                        //string newIDU = "XXXXX";
                                        Console.Write("Name: ");
                                        string newNameU = Console.ReadLine();
                                        Console.Write("Description: ");
                                        string newDescriptionU = Console.ReadLine();
                                        Console.Write("Units in Stock: ");
                                        float newUnit = float.Parse(Console.ReadLine());
                                        Console.Write("Minimum Units:");
                                        float newMinimumU = float.Parse(Console.ReadLine());
                                        Console.Write("Price Paid: ");
                                        float newPaidU = float.Parse(Console.ReadLine());
                                        Console.Write("Sell Price: ");
                                        float newSellU = float.Parse(Console.ReadLine());

                                        Unit newItemU = new Unit(newNameU, newDescriptionU, newUnit, newMinimumU, newPaidU, newSellU);

                                        myStock.AddItem(newItemU);

                                        break;

                                    default:
                                        Console.WriteLine("Invalid Option");
                                        break;
                                }

                                myStock.SaveFile();
                                break;

                            case "4":
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
                    Console.WriteLine("");
                    myStock.BuyList();
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("SALES REPORT");
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("MANAGE USERS");
                    Console.WriteLine("");

                    bool loopBreakUser = true;
                    while(loopBreakUser)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Choose one option:");
                        Console.WriteLine("1. List Users");
                        Console.WriteLine("2. Add New User");
                        Console.WriteLine("3. Delete User");
                        Console.WriteLine("4. Go to Main Menu");

                        string inputUser = Console.ReadLine();
                        Console.WriteLine("");

                        switch(inputUser)
                        {
                            case "1":
                                myUsers.ListUsers();
                                break;

                            case "2":   
                                myUsers.CreateUser();
                                break;

                            case "3":
                                myUsers.DeleteUser();
                                break;

                            case "4":
                                Console.WriteLine("Going to Main Menu");
                            //Maybe add an animation here.
                                Thread.Sleep(2000);
                                loopBreakUser = false;
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("Please enter a valid choice.");
                                break;
                        }
                    }

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