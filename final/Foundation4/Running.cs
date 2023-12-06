using System;

class Running : Activity
{
    private double _distance;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetPace()
    {
        return GetDuration() / _distance;
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
    
    public override string GetSummary()
    {
        string _summary = $"{GetDate()} Running ({GetDuration()} min) - Distance {FormatDouble(_distance)} miles, Speed {FormatDouble(GetSpeed())} mph, Pace: {FormatDouble(GetPace())} min per mile.";
        return _summary;
    }
}