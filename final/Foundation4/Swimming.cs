using System;

class Swimming : Activity
{
    private int _lap;

    public Swimming(string date, int duration, int lap) : base(date, duration)
    {
        _lap = lap;
    }

    public override double GetDistance()
    {
        return _lap * 50 / 1000 * 0.62;
    }
    
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
    
    public override string GetSummary()
    {
        string _summary = $"{GetDate()} Swimming ({GetDuration()} min) - Distance {FormatDouble(GetDistance())} miles, Speed {FormatDouble(GetSpeed())} mph, Pace: {FormatDouble(GetPace())} min per mile.";
        return _summary;
    }
}