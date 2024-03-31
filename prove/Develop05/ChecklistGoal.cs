using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int GetBonus()
    {
        int total = 0;
        bool status = IsComplete();

        if (status == true) {
            total += _bonus;
        }

        return total;
    }

    public override void RecordEvent()
    {
        if (IsComplete() == false) {
            
            _amountCompleted++;
            

        } else {
            Console.WriteLine("You have already completed this goal.");
        }
        
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target) {
            return true;
        } else {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string status;
        bool complete = IsComplete();
        if (complete == true) {
            status = "X";
        } else {
            status = " ";
        }
        return $"[{status}] {GetName()} ({GetDescription()}) === Currently Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }
}