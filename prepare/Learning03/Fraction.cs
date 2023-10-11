using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTopNumber()
    {
        return _top;
    }
    public void SetTopNumber(int topNumber)
    {
        _top = topNumber;
    }
    public int GetBottomNumber()
    {
        return _bottom;
    }
    public void SetBottomNumber(int bottomNumber)
    {
        _bottom = bottomNumber;
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

    public void DisplayFraction()
    {
        Console.WriteLine($"The fraction is: {_top}/{_bottom}");
    }


}