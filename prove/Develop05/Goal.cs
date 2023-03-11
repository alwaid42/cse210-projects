public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;

    public Goal(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public void ReturnGoal()
    {
        string completed = " ";
        if(IsComplete())
        {
            completed = "x";
        }

        Console.WriteLine($"[{completed}] {_goalName} ({_goalDescription})");
    }

    public void ReturnGoalName()
    {
        Console.WriteLine($"{_goalName}");
    }

    public abstract string WriteFile();
}