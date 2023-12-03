using System;

public class Lectures : Events
{
    //Define Lecture class properties
    private string _speaker;
    private int _capacity;

    //Getters and Setters
    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }
    
    //Override method for specific FullMessage details
    public override string GetSpecificDetails()
    {
        string details = $"Speaker: {GetSpeaker()}\nSeating Capacity: {GetCapacity()}";
        return details;
    }

}