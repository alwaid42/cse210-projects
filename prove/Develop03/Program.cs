using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture{};
        Console.WriteLine("Welcome to Scripute Master Program!");
        Console.WriteLine("Enter the scripute Refence in the format book Chapter:Verses (Proverbs 3:5-6 for example):");
        string referenceText = Console.ReadLine();

        char[] delimiterChars = {' ', ':'};
        string[] partsReference = referenceText.Split(delimiterChars);

        Console.WriteLine("Enter the scripute text:");
        string scriptureText = Console.ReadLine();
        List<string> partsText = scriptureText.Split(' ').ToList();

        myScripture.SetScripture(partsReference[0], partsReference[1], partsReference[2], partsText);

        bool indicator = true;
        
        while(indicator)
        {
            Console.Clear();
            myScripture.GetScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                indicator = false;
            }

            bool isHidden  = myScripture.CompletelyHidden();
            if(isHidden)
            {
                indicator = false;
            }
            
            myScripture.HideWords();
        }
    }
}