using System;

public class Cycling : Activity
{   
    private double _speed;

    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double time = GetDuration() / 60;
        double distance = _speed * time;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    
}