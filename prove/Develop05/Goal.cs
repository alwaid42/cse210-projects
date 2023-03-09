public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _points;

    public Goal(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract void IsComplete();
    public abstract void AddPoints();
    public void ReturnGoal()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
    }

    public string WriteFile()
    {
        return "asdfasdf";
    }
}