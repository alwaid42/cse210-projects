using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture{};

        string filename = "scriptures.txt";
        Random rnd = new Random();
        string line = System.IO.File.ReadLines(filename).Skip(rnd.Next(10)).Take(1).First();
        string[] partsLine = line.Split('|');

        // Splits the reference text and store the value of Book, chapter and text.
        string referenceText = partsLine[0];
        char[] delimiterChars = {' ', ':'};
        string[] partsReference = referenceText.Split(delimiterChars);

        //Splits the scripture text into a list of words
        string scriptureText = partsLine[1];
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