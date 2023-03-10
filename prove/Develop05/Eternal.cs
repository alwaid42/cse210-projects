public class Eternal : Goal
{
    public Eternal (string name, string description, int points) : base (name, description, points)
    {
        
    }

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override void AddPoints()
    {
        
    }

    public override string WriteFile()
    {
        return $"Eternal|{_goalName}|{_goalDescription}|{_points}";
    }
}