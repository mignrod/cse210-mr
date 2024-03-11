using System;

public class Journal
{   
    public List<Entry> _entries;


    PromptGenerator promptGenerator = new PromptGenerator();

    public void AddEntry(Entry newEntry)
    {
        // Initialize the prompt generator
        string promptText = promptGenerator.GetRandomPrompt();

        // Get the current time for the entry record
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();

        // Get the entry from the user
        Console.WriteLine(promptText);
        string entryText = Console.ReadLine();

        _entries = new List<Entry>

        {
            new Entry {_date = date, _promptText = promptText, _entryText = entryText}
    
        };

        _entries.Add(newEntry);


    }

    public void DisplayAll()
    {
        foreach (Entry newEntry in _entries) {
            newEntry.Display();
            Console.WriteLine();

        }
    }

    public void SaveToFile(string file)
    {
        

    }

    public void LoadFromFile(string file)
    {
        
    }
    
}