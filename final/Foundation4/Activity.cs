using System;

abstract class Activity
{
    //Define the Activity class properties
    private string _date;
    private int _duration;
    
    //Constructor to set the properties
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    
    //Getters
    public string GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    //Virtual method to calculate speed
    public virtual double GetSpeed()
    {
        return 0;
    }
    
    //Abstract method to calcuate pace
    public abstract double GetPace();

    //Virtual method to calculate distance
    public virtual double GetDistance()
    {
        return 0;
    }
    
    //Virtual method to format the numbers in the summary
    public virtual string FormatDouble(double value)
    {
        return value.ToString("F1");
    }
    
    //Abstract method to create the summary
    public abstract string GetSummary();
    
}