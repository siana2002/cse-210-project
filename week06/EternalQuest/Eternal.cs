using System;

public class Eternal : Goals
{
    protected int _totalPoints;
    public Eternal(string name, string goals, int points) : base(name, goals, points)
    {
        _totalPoints = 0;
    }

    public override void RecordEvent()
    {
        _totalPoints = _totalPoints + _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetGoalDetails()
    {
        return $"Eternal Goal | {_name} | {_goals} | {_points} ";
    }

    public override string GetGoalRepresentation()
    {
        return $"[ ] {_name} ({_goals})";
    }
}