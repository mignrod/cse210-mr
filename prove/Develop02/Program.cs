using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Print a brief welcome message;
        Console.WriteLine("Welcome to the Journal Program! This is your personal and private Journal");
        
        //Creating the new instance of journal
        Journal myJournal = new Journal();

        while (true) {
            Console.WriteLine("Please select one of the following choices:\n"+
            "1. Write something\n"+
            "2. Display your entries\n"+
            "3. Load your personal journal file\n"+
            "4. Save your journal to a file\n"+
            "5. Quit the program");

            // Request from the user an action to take
            Console.Write("What would you like to do? (1-5): ");
            string choise = Console.ReadLine();

            // Call the class methods for every user selection
            switch (choise) 
            {
                case "1":
                Entry newEntry = new Entry();
                myJournal.AddEntry(newEntry);
                break;

                case "2":
                myJournal.DisplayAll();
                break;

                case "3":
                myJournal.LoadFromFile();
                break;

                case "4":
                myJournal.SaveToFile();
                break;

                // Closing the program and say goodbye!
                case "5":
                Console.WriteLine("Goodbye! And see you soon!");
                return;
 
                // Try to handle invalid selections
                default:
                Console.WriteLine("Invalid selection, please enter a valid option (1 to 5). ");
                break;
            }
        }

    }
}   