using System;

public class Activity
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
    public virtual double CalculateSpeed()
    {
        return 0;
    }
    
    //Virtual method to calcuate pace
    public virtual double CalculatePace()
    {
        return 0;
    }

    //Virtual method to calculate distance
    public virtual double CalculateDistance()
    {
        return 0;
    }
    
    //Method to format the numbers in the summary
    public string FormatDouble(double value)
    {
        return value.ToString("F1");
    }
    
    //Method to display the summary
    public string GetSummary()
    {
        string _summary = $"{GetDate()} {GetType().Name} ({GetDuration()} min): Distance: {FormatDouble(CalculateDistance())} miles, Speed: {FormatDouble(CalculateSpeed())} mph, Pace: {FormatDouble(CalculatePace())} min per mile.";
        return _summary;
    }
    
}