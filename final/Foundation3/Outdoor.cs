using System;

public class Outdoor : Events
{
    //Define the Outdoor class properties
    private string _weather;

    //Constructor to set the Outdoor class properties
    public Outdoor(string title, string description, DateTime date, string address, string type, string weather) : base(title, description, date, address, type)
    {
        _weather = weather;
    }
    
    //Getters and setters
    public string GetWeather()
    {
        return _weather;
    }
    
    //Override method for specific FullMessage details
    public override string GetSpecificDetails()
    {
        string details = $"The weather forecast for that day is: {GetWeather()}";
        return details;
    }

}