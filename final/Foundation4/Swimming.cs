using System;

class Swimming : Activity
{
    //Define the Swimming class properties
    private int _lap;

    //Constructor to set the properties
    public Swimming(string date, int duration, int lap) : base(date, duration)
    {
        _lap = lap;
    }

    //Override method to calculate the distance
    public override double GetDistance()
    {
        return _lap * 50 / 1000 * 0.62;
    }
    
    //Override method to calculate the pace
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }

    //Override method to calculate the speed
    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
    
    //Override method to create summary
    public override string GetSummary()
    {
        string _summary = $"{GetDate()} Swimming ({GetDuration()} min) - Distance: {FormatDouble(GetDistance())} miles, Speed: {FormatDouble(GetSpeed())} mph, Pace: {FormatDouble(GetPace())} min per mile.";
        return _summary;
    }
}