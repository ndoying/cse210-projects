using System;

public class Lectures : Events
{
    //Define Lecture class properties
    private string _speaker;
    private int _capacity;

    //Constructor to set the Lecture class properties
    public Lectures(string title, string description, DateTime date, string address, string type, string speaker, int capacity) : base(title, description, date, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Getters
    public string GetSpeaker()
    {
        return _speaker;
    }
    
    public int GetCapacity()
    {
        return _capacity;
    }
    
    //Override method for specific FullMessage details
    public override string GetSpecificDetails()
    {
        string details = $"Speaker: {GetSpeaker()}\nSeating Capacity: {GetCapacity()}";
        return details;
    }

}