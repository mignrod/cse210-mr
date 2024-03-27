using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
    {
        _name = "Breathing Activity";
        _description = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
    }

    public void Run()
    {
        // Clear the console before show the activity
        Console.Clear();

        // Create a new activity, Set the values and print the starting message
        BreathingActivity breathing = new BreathingActivity();
        breathing.DisplayStartingMessage();

        // Start the activity (Get Ready)
        Console.WriteLine("Get Ready...");
        breathing.ShowSpinner(1);

        // Defining time
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(breathing.GetDuration());
        
        Console.Write("You May Begin in...");
        Thread.Sleep(1000);
        breathing.ShowCountDown(4);

        // Breathe in and Breathe out
        while(startTime < finishTime)
        {
            Console.Write("Breathe in...");
            breathing.ShowCountDown(4);

            Console.WriteLine("");
            Console.Write("Now breathe out...");
            breathing.ShowCountDown(4);
            Console.Clear();

            DateTime currenTime = DateTime.Now;
            startTime = currenTime;
        }

        // Displaying ending message
        breathing.DisplayEndingMessage();
        breathing.ShowSpinner(1);
        Console.Clear();
    }
}