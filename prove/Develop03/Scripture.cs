using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] verse = text.Split(" ");
        foreach (string word in verse)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int NumberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < NumberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();

        }
    }

    public string GetDisplayText()
    {
        foreach(Word word in _words);

            string wholeText = string.Join(" ", _words.Select(word => word.GetDisplayText()));

        return $"{_reference.GetDisplayText() } - {wholeText}";
    }
    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}