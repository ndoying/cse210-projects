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

    //Override method to calculate the speed
    public override double CalculateSpeed()
    {
        return _speed;
    }
    
    //Override method to calculate the distance
    public override double CalculateDistance()
    {
        return _speed * GetDuration() / 60;
    }
    
    //Override method to calculate the pace
    public override double CalculatePace()
    {
        return GetDuration() / CalculateDistance();
    }
    
}