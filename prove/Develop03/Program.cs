using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer Program!\nTry to remember your favorite Scriptures!");

        // Creating a scripture for example
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths straight.";
        Scripture fullScripture = new Scripture(reference, text);

        bool quitProgram = false;
        string response;
        while (!quitProgram)
        {
            Console.WriteLine("Press the Enter key to continue or type quit to finish the program.");
            response = Console.ReadLine();

            Console.WriteLine(fullScripture.GetDisplayText());

            fullScripture.HideRandomWords(2);

            fullScripture.IsCompletelyHidden();

            if (response.ToLower() == "quit")
            {
                quitProgram = true;

            }
        }
    }
}