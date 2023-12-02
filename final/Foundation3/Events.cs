using System;

public class Events
{
    private string _title;
    private string _description;
    private DateTime _dateAndTime;
    // private DateTime _time;
    private string _address;

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string desc)
    {
        _description = desc;
    }

    public DateTime GetDateTime()
    {
        return _dateAndTime;
    }

    public void SetDateTime(DateTime dateTime)
    {
        _dateAndTime = dateTime;
    }

    // public Address GetAddress()
    // {
    //     return _address;
    // }

    public void SetAddress(string location)
    {
        _address = location;
    }

    // public Events(string title, string desc, DateTime dateTime, Address address)
    // {
    //     _title = title;
    //     _description = desc;
    //     _dateAndTime = dateTime;
    //     _address = address;
    // }

    public void StandardMessage()
    {
        Console.WriteLine($"'{_title}'\n {_description}\n Date/Time: {_dateAndTime}\n Location: {_address}");

    }
    public void FullMessage()
    {

    }

    public void ShortMessage()
    {

    }
}