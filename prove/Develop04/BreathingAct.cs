using System;

//This class controls the Breathing activity using several methods from the base class.
public class BreathingAct : Activities
{
    //Constructor to pass name and description parameters to the base class.
    public BreathingAct() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.")
    {
        
    }
    //Method to run the Breathing activity.
    public void RunBreathe()
    {
        GetUserDuration();
        GetReady();
        //While loop calling the Timer function to control the duration of the activity.
        while(Timer())
        {
            Console.Write($"\nBreathe in...");
            CountDown(3);
            Console.Write($"\nNow breathe out...");
            CountDown(5);
            Console.WriteLine();
        }
        DisplayWellDone();
    }
}
