using System;

public class Checklist : Goals
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public Checklist(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"{_amountCompleted} / {_target}");

        if (JustCompleted())
        {
            GetBonus();
            Console.WriteLine($"Goal completed. You earned bonus {_bonus} points. ");
        }
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public bool JustCompleted()
    {
        return _amountCompleted == _target;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
   
    public override string GetGoalDetails()
    {
        return $"Checklist Goal | {_name} | {_goals} | {_points} | {_amountCompleted} | {_target} | {_bonus}";
    }
    public override string GetGoalRepresentation()
    {
        return $"[ ] {_name} ({_goals}) -- Completed: {_amountCompleted} / {_target} ";
    }
}