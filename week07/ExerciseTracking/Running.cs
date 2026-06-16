using System;

public class Running : Activity
{   
    private int _distance;

    public Running(string date, double minutes, int distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = (_distance / GetDuration()) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = GetDuration() / _distance;
        return pace;
    }
    
}