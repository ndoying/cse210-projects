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
    public override double CalculateDistance()
    {
        return _distance;
    }

    //Override method to calculate the pace
    public override double CalculatePace()
    {
        return GetDuration() / _distance;
    }

    //Override method to calculate the speed
    public override double CalculateSpeed()
    {
        return 60 / CalculatePace();
    }
    
}