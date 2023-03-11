public class Eternal : Goal
{
    public Eternal (string name, string description, int points) : base (name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
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
}