using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] verse = text.Split(" ");
        for (int i = 0; i < verse.Length; i++)
        {
            Word newWords = new Word(verse[i]);
            _words.Add(newWords);
        }
    }

    public void HideRandomWords(int NumberToHide)
    {
        Random random = new Random();
        while(NumberToHide < 4)
        {
            int index = random.Next(_words.Count);
            // _words[index].Hide();
            NumberToHide++;
            Console.WriteLine(_words[index].ToString());



        }

    }

    public string GetDisplayText()
    {
        foreach(Word word in _words)
           {
            return $"{_reference.GetDisplayText()}";
           }
        return $"{_reference.GetDisplayText()}";
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