using System;

class Running : Activity
{
    //Define the Running class properties
    private double _distance;

    //Constructor to set the properties
    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    //Override method to calculate the distance
    public override double GetDistance()
    {
        return _distance;
    }

    //Override method to calculate the pace
    public override double GetPace()
    {
        return GetDuration() / _distance;
    }

    //Override method to calculate the speed
    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
    
    // public void GetSummary()
    // {
    //     base.GetSummary();
    // }
    
    //Override method to create summary.
    // public override string GetSummary()
    // {
    //     string _summary = $"{GetDate()} Running ({GetDuration()} min) - Distance: {FormatDouble(_distance)} miles, Speed: {FormatDouble(GetSpeed())} mph, Pace: {FormatDouble(GetPace())} min per mile.";
    //     return _summary;
    // }
}