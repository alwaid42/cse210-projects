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

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return _completed;
    }
    public override void AddPoints()
    {
        
    }

    public override string WriteFile()
    {
        return $"Simple|{_goalName}|{_goalDescription}|{_points}|{_completed}";
    }
}