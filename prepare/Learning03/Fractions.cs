using System;

public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        // Set to default 1/1
        _top = 1;
        _bottom = 1;

    }

    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}