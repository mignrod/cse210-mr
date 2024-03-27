using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "reflect on the good things in your life by having your list as many things as you can in certain area.";

        _prompts = new List<string>() {
            "Who are people that you appreciate?.",
            "What are personal strengths of yours?.",
            "Who are people that you have helped this week?.",
            "When have you felt the Holy Ghost this month?.",
            "Who are some of your personal heroes?.",
        };
    }

    public void Run()
    {
        // Clear the console before show the activity
        Console.Clear();

        // Create a new activity, Set the values and print the starting message
        ListingActivity listing = new ListingActivity();
        listing.DisplayStartingMessage();

        // Start the activity (Get Ready)
        Console.WriteLine("Get Ready...");
        listing.ShowSpinner(1);

        Console.WriteLine("List as many responses you can to the following prompt: ");
        listing.GetRandomPrompt();
        Console.Write("You May Begin in...");
        Thread.Sleep(1000);
        listing.ShowCountDown(5);

        // Defining time
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(listing.GetDuration());

        while(startTime < finishTime)
        {
            listing.GetListFromUser();

            DateTime currenTime = DateTime.Now;
            startTime = currenTime;
            _count++;
        }
        Console.WriteLine($"You have response {_count} answers!");

        // Display standard ending message.
        listing.DisplayEndingMessage();
        listing.ShowSpinner(1);
        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        string randomPrompt = _prompts[i];

        Console.WriteLine($@"
---   {randomPrompt}   ---");
    }

    public List<string> GetListFromUser()
    {

        List<string> answers = new List<string>();
        Console.Write("> ");
        string answer = Console.ReadLine();

        answers.Add(answer);

        return answers;
        
    }
    
}