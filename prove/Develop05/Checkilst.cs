public class Checklist : Goal
{
    //stores the times the goal needs to be accomplished
    private int _times;
    //stores bonus points for reaching the number of times
    private int _bonus;

    public Checklist (string name, string description, int points, int times, int bonus) : base (name, description, points)
    {
        _times = times;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {

    }
    public override void IsComplete()
    {
        
    }
    public override void AddPoints()
    {
        
    }
}