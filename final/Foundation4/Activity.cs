using System;

abstract class Activity
{
    private string _date;
    private int _duration;
    
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    

    public string GetDate()
    {
        return _date;
    }

    // public void SetDuration(int duration)
    // {
    //     _duration = duration;
    // }
    public int GetDuration()
    {
        return _duration;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }
    
    public abstract double GetPace();

    public virtual double GetDistance()
    {
        return 0;
    }
    
    public virtual string FormatDouble(double value)
    {
        return value.ToString("F1");
    }
    
    public abstract string GetSummary();
    
}