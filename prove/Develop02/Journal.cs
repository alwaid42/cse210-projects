public class Journal
{
   //Responsibilities:
    //Keeps track of the entries.
    public List<Entry> _entries = new List<Entry>(); 

    //Behaviors:
    //Displays the entries in the journal.
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine(" ");
        }
    }
}