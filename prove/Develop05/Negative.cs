public class Negative : Goal
{
    public Negative (string name, string description, int points) : base (name, description, points)
    {
           
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Sorry. You have lost {_points} points!");
        int negPoints = _points * -1;
        return negPoints;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string WriteFile()
    {
        return $"Negative|{_goalName}|{_goalDescription}|{_points}";
    }

    public override void ReturnGoal()
    {
        string completed = " ";
        Console.WriteLine($"[{completed}] {_goalName} ({_goalDescription}) -- Bad Habit");
    }
}