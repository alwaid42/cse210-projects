public class Checklist : Goal
{
    //stores the times the goal needs to be accomplished
    private int _times;
    //stores bonus points for reaching the number of times
    private int _bonus;
    //stores number of times the goal was completed
    private int _accomplished;

    public Checklist (string name, string description, int points, int times, int bonus) : base (name, description, points)
    {
        _times = times;
        _bonus = bonus;
        _accomplished = 0;
    }

    public override int RecordEvent()
    {
        _accomplished++;
        if(_accomplished == _times)
        {
            Console.WriteLine($"Congratulations! You have earned {_points + _bonus} points!");
            return _points + _bonus;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
    }
    public override bool IsComplete()
    {
        if(_accomplished >= _times)
        {
            return true;
        }
        else
            return false;
    }

    public override string WriteFile()
    {
        return $"Checklist|{_goalName}|{_goalDescription}|{_points}|{_times}|{_bonus}|{_accomplished}";
    }

    public override void ReturnGoal()
    {
        string completed = " ";
        if(IsComplete())
        {
            completed = "x";
        }

        Console.WriteLine($"[{completed}] {_goalName} ({_goalDescription}) -- Currently completed: {_accomplished}/{_times}");
    }
}