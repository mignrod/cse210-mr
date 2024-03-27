using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {

            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.Write($@"
Menu Options
===========================================
Please select one of the following choises:
1. Breathing activity.
2. Reflecting activity.
3. Listing activity.
4. Quit.
===========================================
Select a choise from the menu:  ");
            string choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                BreathingActivity breathe = new BreathingActivity();
                breathe.Run();
                break;

                case "2":
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
                break;

                case "3":
                ListingActivity listing = new ListingActivity();
                listing.Run();
                break;

                case "4":
                Console.WriteLine("GoodBye!!");
                return;
            }
        }

    }
}