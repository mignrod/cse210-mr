using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;



    }

    public void HideRandomWords(int NumberToHide)
    {
        
    }

    public string GetDisplayText()
    {
        foreach(Word word in _words)
        {
            word.Show();

        }

        return $"{_reference.GetDisplayText()} - .";
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