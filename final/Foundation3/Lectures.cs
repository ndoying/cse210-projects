using System;

public class Lectures : Events
{
    private string _speaker;
    private int _capacity;

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

    public void GetFullMessage()
    {

    }
}