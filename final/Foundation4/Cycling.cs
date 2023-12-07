using System;

class Cycling : Activity
{
    //Define the Cycling class properties
    private double _speed;

    //Constructor to set the properties
    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    //Override method to calculate the distance
    public override double GetDistance()
    {
        return _speed * GetDuration() / 60;
    }
    
    //Override method to calculate the pace
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
    
    //Override method to create summary
    public override string GetSummary()
    {
        string _summary = $"{GetDate()} Cycling ({GetDuration()} min) - Distance: {FormatDouble(GetDistance())} miles, Speed: {FormatDouble(_speed)} mph, Pace: {FormatDouble(GetPace())} min per mile.";
        return _summary;
    }
}