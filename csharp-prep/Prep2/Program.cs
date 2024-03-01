using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");

        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";

        }
        else if (gradePercentage >= 80)
        {
            letter = "B";

        }
        else if (gradePercentage >= 70)
        {
            letter = "C";

        }
        else if (gradePercentage >= 60)
        {
            letter = "D";

        }
        else
        {
            letter = "F";
        }

        string sign = "";
        if ((gradePercentage % 10) >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";

        }
        else if ((gradePercentage % 10) < 3 && letter != "F")
        {
            sign = "-";

        }

        else
        {
            sign = "";

        }
        
        Console.WriteLine($"Your grade letter is {letter}{sign}");
        Console.WriteLine("");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You pass the class!.");

        }
        else
        {
            Console.WriteLine("Sorry! You don't approve this class! Better luck the next time!.");

        }
        
    }
}