public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    // public Activity(string name, string description, int duration)
    // {
    //     _name = name;
    //     _description = description;
    //     _duration = duration;
    // }

    public void DisplayStart()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(" ");
        Console.WriteLine($"{_description}");
        Console.WriteLine(" ");
        Console.WriteLine("How long, in seconds, would you like your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        PausingSpinner(7);
        Console.WriteLine(" ");
    }

    public void DisplayFinish() 
    {
        Console.WriteLine("Well done!!");
        PausingSpinner(7);
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        PausingSpinner(10);
        Console.Clear();
    }

    protected void PausingSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");
            
            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    protected void PausingCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}