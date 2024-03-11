using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        _prompts = new List<string>() {
            "What was the best part of today?",
            "What was the most interesting person you meet today?",
            "Write something about your experience studying the scriptures today.",
            "Write down something you are grateful for today.",
            "Write about an experience in which you were able to feel accompanied by the spirit.",
            "Write about a tender mercy you noticed today.",
            "Is there an act of service you would like to do today?",
            "Write about a positive interaction you had with someone else today.",
            "Write about an act of service either you witnessed or performed today.",
            "Write about a moment that reminded you of the Savior today.",
            "Write whatever you want about your day.",
            "Write about something you learned today.",
            "Have you had a positive interaction with anyone else today? Write about this.",
            "If you had anything to teach about the Savior today, what would that be?",
            "Write about the most interesting person you interacted with today.",
            "Write about your work today.",
            "How did I see the hand of the Lord in my life today?",
            "If I had one thing I could do over today, what would it be?",
        };


        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }
}