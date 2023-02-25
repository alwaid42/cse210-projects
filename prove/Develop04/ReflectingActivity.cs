public class ReflectingActivity : Activity
{   
    private List<string> _questions = new List<string>();
    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 50;
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
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

        /* To make my Reflecting Activity select each question once before repeating I made a list with the indexes
        of the questions, (0 to _questions.Count-1 ), and each time I use one number I remove that number from the list
        If the list is empty I fill it again with the indexes of questions again*/

        List<int> randomNumbers = new List<int>();
        int questionNumber = _questions.Count;
        for (int i=0; i < questionNumber; i++)
        {
            randomNumbers.Add(i);
        }

        while (DateTime.Now < endTime)
        {   
            int notUsedQuestions = ((randomNumbers.Count)-1);
            Random rnd = new Random();
            int rng = rnd.Next(notUsedQuestions);

            QuestionGenerator(randomNumbers[rng]);
            PausingSpinner(15);
            Console.Write("\n");
            randomNumbers.RemoveAt(rng);
            if (randomNumbers.Count == 0)
            {
                for (int i=0; i < questionNumber; i++)
                {
                    randomNumbers.Add(i);
                }
            }
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

    private void QuestionGenerator(int i)
    {
        Console.Write(" > ");
        Console.Write(_questions[i]);
        Console.Write(" ");
    }
}