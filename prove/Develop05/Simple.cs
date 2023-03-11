public class Simple : Goal
{
    private bool _completed;
    public Simple (string name, string description, int points) : base (name, description, points)
    {
        _completed = false;   
    }

    public Simple (string name, string description, int points, bool completed) : base (name, description, points)
    {
        _completed = completed;   
    }

    public override int RecordEvent()
    {
        _completed = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }
    public override bool IsComplete()
    {
        return _completed;
    }

    public override string WriteFile()
    {
        return $"Simple|{_goalName}|{_goalDescription}|{_points}|{_completed}";
    }

    public override void ReturnGoal()
    {
        string completed = " ";
        if(IsComplete())
        {
            completed = "x";
        }

        Console.WriteLine($"[{completed}] {_goalName} ({_goalDescription})");
    }
}