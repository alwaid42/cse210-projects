public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 50;
    }

    public void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now  < endTime)
        {
            Console.Write("Breath in... ");
            PausingCountdown(5);
            Console.Write("\n");
            Console.Write("Now breath out... ");
            PausingCountdown(7);
            Console.Write("\n");
            Console.WriteLine(" ");
        }
    }
}