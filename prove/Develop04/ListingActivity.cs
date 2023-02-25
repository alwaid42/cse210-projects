public class ListingActivity : Activity
{
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 50;
    }

    public void RunActivity()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(" ");
        PromptGenerator();
        Console.WriteLine(" ");
        Console.Write("You may begin in: ");
        PausingCountdown(6);
        Console.Write("\n");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> listing = new List<string>();
        while (DateTime.Now < endTime)
        { 
            Console.Write("> ");
            string item = Console.ReadLine();
            listing.Add(item);
        }
        Console.WriteLine($"You listed {listing.Count} items!");
        Console.WriteLine(" ");
    }

    private void PromptGenerator()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        prompts.Add("What are the things that make you happy?");

        int promptNumber = prompts.Count;
        Random rnd = new Random();
        Console.Write(" --- ");
        Console.Write(prompts[rnd.Next(promptNumber-1)]);
        Console.Write(" --- \n");
    }
}