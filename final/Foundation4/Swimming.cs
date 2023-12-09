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
    public override double CalculateDistance()
    {
        return _lap * 50 / 1000 * 0.62;
    }
    
    //Override method to calculate the pace
    public override double CalculatePace()
    {
        return GetDuration() / CalculateDistance();
    }

    //Override method to calculate the speed
    public override double CalculateSpeed()
    {
        return 60 / CalculatePace();
    }
    
}