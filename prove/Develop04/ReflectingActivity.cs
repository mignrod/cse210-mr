using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _prompts = new List<string>() {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        _questions = new List<string>() {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };

         _name = "Reflecting Activity";
        _description = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    }

    public void Run()
    {
        // Clear the console before show the activity
        Console.Clear();

        // Create a new activity, Set the values and print the starting message
        ReflectingActivity reflecting = new ReflectingActivity();
        reflecting.DisplayStartingMessage();

        // Start the activity (Get Ready)
        Console.WriteLine("Get Ready...");
        reflecting.ShowSpinner(1);

        // Display the prompt
        Console.WriteLine("Consider the following prompt: ");
        reflecting.DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();

        // Get ready for the questions
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You May Begin in...");
        Thread.Sleep(1000);
        reflecting.ShowCountDown(5);

        // Defining time
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(reflecting.GetDuration());

        // Display questions
        while (startTime < finishTime)
        {

            reflecting.DisplayQuestions();
            Thread.Sleep(3000);
            reflecting.ShowSpinner(1);
            Console.Clear();

            DateTime currenTime = DateTime.Now;
            startTime = currenTime;
        }

        // Display standard ending message.
        reflecting.DisplayEndingMessage();
        reflecting.ShowSpinner(1);
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        string randomPrompt = _prompts[i];

        return $@"
---   {randomPrompt}   ---";
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int i = random.Next(_questions.Count);
        string randomQuestion = _questions[i];

        return $"> {randomQuestion}";
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());

    }

    public void DisplayQuestions()
    {
        Console.Write($"{GetRandomQuestion()} ");


    }
}