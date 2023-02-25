public class ReflectingActivity : Activity
{
    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 50;
    }

    public void RunActivity()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(" ");
        PromptGenerator();
        Console.WriteLine(" ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        PausingCountdown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            QuestionGenerator();
            PausingSpinner(15);
            Console.Write("\n");
        }
        Console.WriteLine(" ");
    }

    private void PromptGenerator()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        prompts.Add("Think of a time when you worked really hard");

        int promptNumber = prompts.Count;
        Random rnd = new Random();
        Console.Write(" --- ");
        Console.Write(prompts[rnd.Next(promptNumber-1)]);
        Console.Write(" --- \n");
    }

    private void QuestionGenerator()
    {
        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
    
        int questionNumber = questions.Count;
        Random rnd = new Random();
        Console.Write(" > ");
        Console.Write(questions[rnd.Next(questionNumber-1)]);
        Console.Write(" ");
    }
}