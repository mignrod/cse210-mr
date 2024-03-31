using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goal = new GoalManager();
        Console.WriteLine("Welcome to the Goal Manager Program!!!\n");
        Console.WriteLine("You can track your goals, save them, and create a new ones!");
        Console.Write("Please click ENTER to start!!!");
        Console.ReadKey();

        while(true)
        {
            goal.Start();
            string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    goal.CreateGoal();
                    break;

                    case "2":
                    goal.ListGoalDetails();
                    Console.WriteLine("Click Enter to continue.. ");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case "3":
                    goal.SaveGoals();
                    break;

                    case "4":
                    goal.LoadGoals();
                    break;

                    case "5":
                    goal.RecordEvent();
                    break;

                    case "6":
                    Console.WriteLine("GoodBye!!");
                    return;
                }
        }
    }
}