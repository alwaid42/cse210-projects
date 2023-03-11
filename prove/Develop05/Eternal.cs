public class Eternal : Goal
{
    public Eternal (string name, string description, int points) : base (name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string WriteFile()
    {
        return $"Eternal|{_goalName}|{_goalDescription}|{_points}";
    }

    public override void ReturnGoal()
    {
        string completed = " ";
        Console.WriteLine($"[{completed}] {_goalName} ({_goalDescription})");
    }
}