using System;
using System.Drawing;

public class Simple : Goals
{
    protected bool _isComplete;

    public Simple(string name, string goals, int points) : base(name, goals, points)
    {}

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetGoalDetails()
    {
        return $"Simple Goal | {_name} | {_goals} | {_points} ";
    }

    public override string GetGoalRepresentation()
    {
        if (_isComplete)
        {
            return $"[X] {_name} ({_goals})";
        }

        return $"[ ] {_name} ({_goals})";
    }
}