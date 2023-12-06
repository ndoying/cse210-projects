using System;

class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetDuration() / 60;
    }
    
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
    
    public override string GetSummary()
    {
        string _summary = $"{GetDate()} Cycling ({GetDuration()} min) - Distance {FormatDouble(GetDistance())} miles, Speed {FormatDouble(_speed)} mph, Pace: {FormatDouble(GetPace())} min per mile.";
        return _summary;
    }
}