using System;
using System.IO;

public class Stock
{
    private List<Item> _inventory = new List<Item>();

    public void ListItems()
    {
        foreach(Item i in _inventory)
        {
            i.ReturnItem();
        }
    }

    public void UpdateItem(int index)
    {
        _inventory[index-1].ReturnItem();
        Console.WriteLine("");
        Console.WriteLine("Which field do you need to update?");
        Console.WriteLine("1. Name");
        Console.WriteLine("2. Description");
        Console.WriteLine("3. Quantity");
        Console.WriteLine("4. Minimum Quantity");
        Console.WriteLine("5. Price Paid");
        Console.WriteLine("6. Sell Price");
        string updateField = Console.ReadLine();
        switch(updateField)
        {
            case "1":
                _inventory[index-1].UpdateName();
                break;

            case "2":
                _inventory[index-1].UpdateDescription();
                break;

            case "3":
                _inventory[index-1].UpdateQuantity();
                break;

            case "4":
                _inventory[index-1].UpdateMinimum();
                break;

            case "5":
                _inventory[index-1].UpdatePaid();
                break;

            case "6":
                _inventory[index-1].SellName();
                break;

            default:
                Console.WriteLine("Invalid Option.");
                break;
        }
        Console.WriteLine("");
        _inventory[index-1].ReturnItem();
    }

    public void AddItem(Item newItem)
    {
        _inventory.Add(newItem);
    }

    public void SaveFile()
    {
        string file = "stock.txt";
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Item it in _inventory)
            {
                outputFile.WriteLine(it.WriteFile());
            }
        }
    }

    public void ReadFile()
    {
        string filename = "stock.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            char[] delimiterChars = {'|'};
            string[] parts = line.Split(delimiterChars);

            /*
            string f0 = "Volume|Length|Weight|Unit";
            string[] f1 = f0.Split(delimiterChars);
            */

            if(String.Equals("Volume", parts[0]))
            {
                int id = int.Parse(parts[1]);
                float quantity = float.Parse(parts[4]);
                float minimun = float.Parse(parts[5]);
                float paid = float.Parse(parts[6]);
                float sell = float.Parse(parts[7]);

                Volume newItemV = new Volume(id, parts[2], parts[3], quantity, minimun, paid, sell);

                _inventory.Add(newItemV);
            }
            else if(String.Equals("Length", parts[0]))
            {
                int id = int.Parse(parts[1]);
                float quantity = float.Parse(parts[4]);
                float minimun = float.Parse(parts[5]);
                float paid = float.Parse(parts[6]);
                float sell = float.Parse(parts[7]);

                Length newItemL = new Length(id, parts[2], parts[3], quantity, minimun, paid, sell);

                _inventory.Add(newItemL);
            }
            else if(String.Equals("Weight", parts[0]))
            {
                int id = int.Parse(parts[1]);
                float quantity = float.Parse(parts[4]);
                float minimun = float.Parse(parts[5]);
                float paid = float.Parse(parts[6]);
                float sell = float.Parse(parts[7]);

                Weight newItemW = new Weight(id, parts[2], parts[3], quantity, minimun, paid, sell);

                _inventory.Add(newItemW);
            }
            else if(String.Equals("Unit", parts[0]))
            {
                int id = int.Parse(parts[1]);
                int quantity = int.Parse(parts[4]);
                int minimun = int.Parse(parts[5]);
                float paid = float.Parse(parts[6]);
                float sell = float.Parse(parts[7]);

                Unit newItemU = new Unit(id, parts[2], parts[3], quantity, minimun, paid, sell);

                _inventory.Add(newItemU);
            }
            else
            {
                //not defined yet
            }
        }
    }

    public void BuyList()
    {
        int count1 = 1;
        int count2 = 1;
        Dictionary<int, int> myDict = new Dictionary<int, int> ();

        foreach (Item it in _inventory)
        {
            if (it.LowQuantity())
            {
                Console.Write($"{count1}. ");
                it.ReturnItem();
                myDict.Add(count1, count2);
                count1++;
            }
            count2++;
        }


        if (count1 > 1)
        {    
            string input = " ";
            do
            {

                Console.WriteLine("Which item number in the list you want to update? To finish updating press enter");
                input = Console.ReadLine();
                if (input != "")
                {
                    int index = int.Parse(input);
                    int teste = myDict[index];
                    UpdateItem(teste);
                }
                
            } while (input != "");
        }
        else
        {
            Console.WriteLine("There are no items in Low Quantity.");
        }

    }
}