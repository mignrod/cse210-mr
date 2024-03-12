using System;
using System.IO;

public class Journal
{   
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        newEntry.Display();
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries) {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}\n> {entry._entryText}\n");

        }
    }

    public void SaveToFile()
    {
        // Store the file name as a string
        Console.Write("What is the filename?: ");
        string file = Console.ReadLine();

        // Write in the file
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");

            }
        }


    }

    public void LoadFromFile()
    {
        // Erase the previous entries before load the saved file
        _entries.Clear();

        Console.Write("What is the file name?: ");
        string file = Console.ReadLine();
        // Read all line in the file
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Entry Data = new Entry();
            string[] parts = line.Split("| ");
            Data._date = parts[0];
            Data._promptText = parts[1];
            Data._entryText = parts[2];
            _entries.Add(Data);
        }
    }  
}