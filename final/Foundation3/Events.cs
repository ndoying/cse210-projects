using System;

public class Events
{
    //Define the Events class properties
    private string _title;
    private string _description;
    private DateTime _dateAndTime;
    private string _address;
    private string _eventType;

    public Events(string title, string description, DateTime date, string address, string type)
    {
        _title = title;
        _description = description;
        _dateAndTime = date;
        _address = address;
        _eventType = type;
    }

    //Virtual method to facilitate FullMessage method
    public virtual string GetSpecificDetails()
    {
        return "";
    }

    //Standard Message String
    public string GetStandardMessage()
    {
        string formattedDateAndTime = _dateAndTime.ToString("yyyy-MMM-dd h:mm tt");
        string standardMessage = $"'{_title}'\n{_description}\nDate/Time: {formattedDateAndTime}\nLocation: {_address}";
        return standardMessage;
    }
    
    //Three required messages
    public void StandardMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Standard Details Message");
        Console.WriteLine(GetStandardMessage());

    }
    
    public void FullMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Full Details Message");
        Console.WriteLine($"{_eventType} Event");
        Console.WriteLine(GetStandardMessage());
        Console.WriteLine(GetSpecificDetails());
    }
    
    public void ShortMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Short Description Message");
        string shortMessageDate = _dateAndTime.ToString("yyyy-MMM-dd");
        Console.WriteLine($"{_eventType} Event\n'{_title}' \n{shortMessageDate}");
    }
}