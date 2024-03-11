public class Entry
{
    public string _date {get; set;}

    public string _promptText {get; set;}

    public string _entryText {get; set;}

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}");
    }
    // public override string ToString()
    // {
    //     return $"Date: {_date} - Prompt: {_promptText}\n{_entryText}";
    // }
}