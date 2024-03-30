using System;

public class SimpleGoal : Goal
{
    private bool _IsComplete = false;

    public SimpleGoal(string name, string description, string points, bool IsComplete) : base(name, description, points)
    {
        _IsComplete = IsComplete;

    }

    public override void RecordEvent()
    {

        if (_IsComplete == false) {
            _IsComplete = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        if(_IsComplete == true)
        {
            return true;
        } else {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
}