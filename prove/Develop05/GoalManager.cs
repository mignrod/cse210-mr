using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 0;
    private int _expNeeded = 500;
    private int _expEarned = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        Console.Clear();
        DisplayPlayerInfo();
        Console.Write($@"
Menu Options
===========================================
Please select one of the following choices:
1. Create New Goal.
2. List Goals.
3. Save Goals.
4. Load Goals.
5. Record Event.
6. Quit.
===========================================
Select a choice from the menu:  ");

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");

    }

    public void ListGoalNames()
    {
        Console.Write($@"
The types of Goals are:
1. Simple Goal
2. Eternal Goal
3. Checklist Goal
Which type of Goal would you like to create? 
");

    }

    public void ListGoalDetails()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++) {
            Console.Write($"{i + 1}. ");
            Console.Write($"{_goals[i].GetDetailsString()}\n");
        }

    }

    public void CreateGoal()
    {
        Console.Clear();
        ListGoalNames();
        string selection = Console.ReadLine();
        switch(selection)
        {
            case "1":
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this Goal? ");
            string points = Console.ReadLine();

            bool IsComplete = false;
            SimpleGoal simple = new SimpleGoal(name, description, points, IsComplete);
            _goals.Add(simple);
            break;

            case "2":
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this Goal? ");
            points = Console.ReadLine();
            
            int counter = 0;
            EternalGoal eternal = new EternalGoal(name, description, points, counter);
            _goals.Add(eternal);
            break;

            case "3":
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this Goal? ");
            points = Console.ReadLine();
            
            Console.Write("How many times does this Goal need to be accomplished for a bonus? ");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = Convert.ToInt32(Console.ReadLine());
            int amountCompleted = 0;
            ChecklistGoal checklist = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
            _goals.Add(checklist);
            break;

        }
    }

    public void RecordEvent()
    {
        // Clear the console
        Console.Clear();

        // Print a list of the currents goals
        ListGoalDetails();
        Console.WriteLine();
        Console.Write("Which Goal did you accomplish? ");
        string eventString = Console.ReadLine();
        int eventIndex = Convert.ToInt32(eventString) -1;
        if (_goals[eventIndex].IsComplete() == false)
        {
            _goals[eventIndex].RecordEvent();
            int scoreEarned = Convert.ToInt32(_goals[eventIndex].GetPoints());

            // Check for bonuses
            int bonus = _goals[eventIndex].GetBonus();
            scoreEarned += bonus;

            _score += scoreEarned;

            Console.WriteLine($"Congratulations! You have earned {scoreEarned} points!");
            Console.WriteLine($"You now have {_score} points");
            CheckLeveUp();
            Console.WriteLine("Click ENTER to continue...");
            Console.ReadKey();
            Console.Clear();

        } else {
            Console.WriteLine("You have already completed this goal. Try recording another goal!");
            Thread.Sleep(3000);
            Console.Clear();  
        }
        
    }

    public void CheckLeveUp()
    {
        _expEarned =+ _score;
        if(_expEarned >= _expNeeded) {
            _level++;
            _expEarned -= _expNeeded;
            _expNeeded += 500;
            Console.WriteLine($"Congratulations!!\n You have reached the level *{_level}*");

        }
    }

    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename for the Goal file? ");
        fileName = Console.ReadLine();

        // Write the file to save
        using (StreamWriter outputfile = new StreamWriter(fileName))
        {
            int totalScore = _score;
            int totalLevel = _level;
            outputfile.WriteLine(totalScore.ToString());
            outputfile.WriteLine(totalLevel.ToString());

            foreach(Goal goal in _goals)
            {
                outputfile.WriteLine(goal.GetStringRepresentation());

            }
        }
    }

    public void LoadGoals()
    {
        // Clear the Goals before load the file
        _goals.Clear();

        string fileName = "";
        Console.Write("What is the filename for the Goal file? ");
        fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        _score = Convert.ToInt32(lines[0]);
        _level = Convert.ToInt32(lines[1]);

        for(int i = 2; i < lines.Count(); i++)
        {
            string[] parts = lines[i].Split("|");

            if(parts[0] == "SimpleGoal")
            {
                SimpleGoal simple = new SimpleGoal(parts[1], parts[2], parts[3], Convert.ToBoolean(parts[4]));
                _goals.Add(simple);

            } else if(parts[0] == "EternalGoal") {
                EternalGoal eternal = new EternalGoal(parts[1], parts[2], parts[3], Convert.ToInt32(parts[4]));
                _goals.Add(eternal);

            } else if (parts[0] == "ChecklistGoal") {
                ChecklistGoal checklist = new ChecklistGoal(parts[1], parts[2], parts[3], Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
              _goals.Add(checklist);
            }

        }

    }
}