public class Entry
{
    public string _date;

    public string _promptText;

    public string _entryText;

    
    public void Display()
    {
        _date = DateTime.Now.ToShortDateString();
        PromptGenerator Prompt = new PromptGenerator();
        _promptText = Prompt.GetRandomPrompt();
        _entryText = Console.ReadLine();
    }
}