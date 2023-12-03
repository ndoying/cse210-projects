using System;

public class Outdoor : Events
{
    //Define the Outdoor class properties
    private string _weather;
    
    //Getters and setters
    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string forecast)
    {
        _weather = forecast;
    }
    //Override method for specific FullMessage details
    public override string GetSpecificDetails()
    {
        string details = $"The weather forecast for that day is: {GetWeather()}";
        return details;
    }

}