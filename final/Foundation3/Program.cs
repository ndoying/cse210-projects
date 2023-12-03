using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //First Event - setting the properties
        Address eventAddress1 = new Address("30 Rockefeller Center", "New York", "New York");
        DateTime eventDate = new DateTime(2023, 4, 1, 12, 30, 0);
        Lectures eventLecture = new Lectures();
        eventLecture.SetTitle("Post War Japanese Cinema");
        eventLecture.SetDescription("An informative retrospective on the development of modern movie making in Japan.");
        eventLecture.SetDateTime(eventDate);
        eventLecture.SetAddress(eventAddress1.GetFormattedAddress());
        eventLecture.SetEventType("Lecture");
        eventLecture.SetSpeaker("Akira Kurosawa");
        eventLecture.SetCapacity(250);
        //First Event Messages
        eventLecture.StandardMessage();
        eventLecture.FullMessage();
        eventLecture.ShortMessage();

        //Second Event - setting the properties
        Address eventAddress2 = new Address("4377 Hollow Tree Lane", "Norwalk", "Connecticut");
        DateTime eventDate2 = new DateTime(2023, 10, 31, 18, 00, 0);
        Receptions eventReception = new Receptions();
        eventReception.SetTitle("Casper The Ghost Memorial");
        eventReception.SetDescription("A reception to remember Casper and friends.");
        eventReception.SetDateTime(eventDate2);
        eventReception.SetAddress(eventAddress2.GetFormattedAddress());
        eventReception.SetEventType("Reception");
        eventReception.SetEmail("casper@RIP.com");
        //Second Event Messsages
        eventReception.StandardMessage();
        eventReception.FullMessage();
        eventReception.ShortMessage();

        //Third Event - setting the properties
        Address eventAddress3 = new Address("2033 South, 521 West", "Rexburg", "Idaho");
        DateTime eventDate3 = new DateTime(2023, 07, 05, 6, 00, 0);
        Outdoor eventOutdoor = new Outdoor();
        eventOutdoor.SetTitle("Post Fourth Cleanup");
        eventOutdoor.SetDescription("A service project to clean up the park, donuts and hot chocolate provided.");
        eventOutdoor.SetDateTime(eventDate3);
        eventOutdoor.SetAddress(eventAddress3.GetFormattedAddress());
        eventOutdoor.SetEventType("Outdoor");
        eventOutdoor.SetWeather("Warm and sunny.");
        //Third Event Messages
        eventOutdoor.StandardMessage();
        eventOutdoor.FullMessage();
        eventOutdoor.ShortMessage();  
    }
}