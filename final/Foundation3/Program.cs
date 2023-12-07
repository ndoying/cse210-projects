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
        Lectures eventLecture = new Lectures("Post War Japanese Cinema", "An informative retrospective on the development of modern movie making in Japan.", eventDate, eventAddress1.GetFormattedAddress(), "Lecture", "Akira Kurosawa", 250);
        
        //First Event Messages
        eventLecture.StandardMessage();
        eventLecture.FullMessage();
        eventLecture.ShortMessage();

        //Second Event - setting the properties
        Address eventAddress2 = new Address("4377 Hollow Tree Lane", "Norwalk", "Connecticut");
        DateTime eventDate2 = new DateTime(2023, 10, 31, 18, 00, 0);
        Receptions eventReception = new Receptions("Casper The Ghost Memorial", "A reception to remember Casper and friends.", eventDate2, eventAddress2.GetFormattedAddress(), "Reception", "casper@RIP.com");
        
        //Second Event Messsages
        eventReception.StandardMessage();
        eventReception.FullMessage();
        eventReception.ShortMessage();

        //Third Event - setting the properties
        Address eventAddress3 = new Address("2033 South, 521 West", "Rexburg", "Idaho");
        DateTime eventDate3 = new DateTime(2023, 07, 05, 6, 00, 0);
        Outdoor eventOutdoor = new Outdoor("Post Fourth Cleanup", "A service project to clean up the park, donuts and hot chocolate provided.", eventDate3, eventAddress3.GetFormattedAddress(), "Outdoor", "Warm and sunny.");
        
        //Third Event Messages
        eventOutdoor.StandardMessage();
        eventOutdoor.FullMessage();
        eventOutdoor.ShortMessage();  
    }
}