using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;

    }

    public void Hide()
    {
        char[] hiddenLetters = _text.ToCharArray();
        _text.Split(" ");
        
        for(int i = 0; i < _text.Length; i++)
        {
            hiddenLetters[i] = '_';
        }
        _text = new string(hiddenLetters);
        _isHidden = false;
    

    }

    public void Show()
    {
        // Console.WriteLine(_text.IsHidden());

    }

    public bool IsHidden()
    {
        if(_isHidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }
}