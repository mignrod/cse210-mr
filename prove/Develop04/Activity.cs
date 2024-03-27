using System;
using System.Linq;


public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"This activity will help you {_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!!");
        Console.WriteLine($"You have another {_duration} seconds of the {_name}.");

    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinners = new List<string>();
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        spinners.Add("|");

        foreach(string s in spinners)
        {
            Console.Write(s);
            Thread.Sleep(seconds * 1000);
            Console.Write("\b \b");

        }

    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();
    }

    public int GetDuration()
    {
        return _duration;
    }
    
}