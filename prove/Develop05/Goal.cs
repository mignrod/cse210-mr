using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;
    private int _bonus = 0;


    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }

    public int GetBonus()
    {
        return _bonus;
    }
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();


    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string status;
        bool complete = IsComplete();
        if (complete == true) {
            status = "X";
        } else {
            status = " ";
        }
        return $"[{status}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

}