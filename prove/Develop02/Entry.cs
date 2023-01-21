public class Entry
{
   //Responsibilities:
    //Keeps track of the datetime and message of the entry
    public string _date = "";
    public string _prompt = "";
    public string _message = "";

    //Behaviors:
    //Displays the entry information in the format "Date: dd/mm/yyyy - Prompt: "random prompt given" Message", for example: 
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - {_prompt} {_message}");
    }
}