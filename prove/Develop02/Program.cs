using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        bool loopBreak=true;
        Journal myJournal = new Journal();
        PromptGenerator myPrompt = new PromptGenerator();
        while (loopBreak==true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToString("dd/MM/yyyy");
                    Random randomGenerator = new Random();
                    int magicNumber = randomGenerator.Next(0, 9);
                    newEntry._prompt = myPrompt.ReturnPrompt(magicNumber);
                    Console.WriteLine($"{newEntry._prompt}");
                    Console.Write(">");
                    newEntry._message = Console.ReadLine();
                    Console.WriteLine(" ");
                    myJournal._entries.Add(newEntry);
                    break; 

                case "2":
                    myJournal.DisplayJournal();
                    break;

                case "3":
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        char[] delimiterChars = {':','-', '?'};
                        Entry readEntry = new Entry();
                        string[] parts = line.Split(delimiterChars);

                        readEntry._date = parts[1].Trim();
                        readEntry._prompt = parts[2].Trim() + "?";
                        readEntry._message = parts[3].Trim();
                        myJournal._entries.Add(readEntry);
                    }
                    Console.WriteLine(" ");
                    break;

                case "4":
                    Console.WriteLine("What is the filename?");
                    string file = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(file))
                    {
                        // You can add text to the file with the WriteLine method
                        // You can use the $ and include variables just like with Console.WriteLine
                        foreach (Entry entry in myJournal._entries)
                        {
                            outputFile.WriteLine($"Date: {entry._date} - {entry._prompt} {entry._message}");
                        }     
                    }
                    Console.WriteLine(" ");
                    break;

                case "5":
                    loopBreak = false;
                    break;

                default:
                    Console.WriteLine("Please enter a valid choice.");
                    break;
            }
        }
        
    }
}

//https://stackoverflow.com/questions/47251045/while-loop-in-c-sharp-with-switch-statement - Consulted about While loop with switch
//https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1 - Consulted about date time format