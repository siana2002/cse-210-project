using System;

public abstract class Goals
{
    protected string _name;
    protected  string _goals;
    protected int _points;

    public Goals(string name, string goals, int points)
    {
        _name = name;
        _goals = goals;
        _points = points;
    }

    public string Name()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
   
    public virtual string GetGoalDetails()
    {
        return $" ";
    }
    public abstract string GetGoalRepresentation();
}