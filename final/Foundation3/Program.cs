using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address eventAddress1 = new Address("30 Rockefeller Center", "New York", "New York");
        DateTime eventDate = new DateTime(2023, 4, 1, 12, 30, 0);
        Lectures eventLecture = new Lectures();
        eventLecture.SetTitle("Bird Watching in Bermuda");
        eventLecture.SetDescription("An entertaining lecture on the benefits of birding in Bermuda!");
        eventLecture.SetDateTime(eventDate);
        eventLecture.SetAddress(eventAddress1.GetFormattedAddress());
        
        eventLecture.StandardMessage();

        // Console.WriteLine(eventAddress1.GetFormattedAddress());
    }
}