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
        
        goal.Start();
        
    }
}