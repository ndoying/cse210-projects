using System;

//This class controls the Listing activity using several methods from the base class.
public class ListingAct : Activities
{
    //Attributes 
    private int _entryCount = 0;
    private List<string> _listingPrompts = new()
    {
        "Who are people you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    //Constructor to pass name and description parameters to the base class.
    public ListingAct() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }
    //Method to run the List activity.
    public void RunList()
    {
        GetUserDuration();
        GetReady();
        Console.WriteLine("\nList as many responses as you can to the following prompt:\n");
        Console.WriteLine($"--- {_listingPrompts[GetRandom(_listingPrompts.Count)]}---");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();
        //While loop calling the Timer function to control the duration of the activity.
        while(Timer())
        {
            Console.Write(">> ");
            string _userInput = Console.ReadLine();
            _entryCount++;
        }
        Console.WriteLine($"\nYou listed {_entryCount} items!");
        DisplayWellDone();
    }
}