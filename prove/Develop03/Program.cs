using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture{};
        Console.WriteLine("Welcome to Scripute Master Program!");
        Console.WriteLine("Enter the scripute Refence in the format book Chapter:Verses (Proverbs 3:5-6 for example):");
        string referenceText = Console.ReadLine();

        // Splits the reference text and store the value of Book, chapter and text.
        char[] delimiterChars = {' ', ':'};
        string[] partsReference = referenceText.Split(delimiterChars);

        //Splits the scripture text into a list of words
        Console.WriteLine("Enter the scripute text:");
        string scriptureText = Console.ReadLine();
        List<string> partsText = scriptureText.Split(' ').ToList();

        //sets the value of the scripture
        myScripture.SetScripture(partsReference[0], partsReference[1], partsReference[2], partsText);

        //runs the program until the user types quit or all words have been shown hidden
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
            else
            {
                if(myScripture.CompletelyHidden())
                {
                    indicator = false;
                }
                else
                {
                    myScripture.HideWords();
                }
            }
        }
    }
}