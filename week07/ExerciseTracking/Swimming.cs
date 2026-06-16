using System;

public class Swimming : Activity
{   
    private int _numberOfLaps;

    public Swimming(string date, double minutes, int numberOfLaps) : base(date, minutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double distance = _numberOfLaps * 50 / 1000;
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetDuration()) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = GetDuration() / GetDistance();
        return pace;
    }
    
}