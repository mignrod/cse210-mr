using System;

public class EternalGoal : Goal
{
    // Adding to this goal a counter than save how many times the user complete the goal.
    private int _counter = 0;

    public EternalGoal(string name, string description, string points, int counter) : base(name, description, points)
    {
        _counter = counter;
    }

    public override void RecordEvent()
    {
        _counter++;
        Console.WriteLine($"You have completed this goal {_counter} times!");

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_counter}";
    }
}