using System;
using System.ComponentModel;

public class BreathingAct : Activities
{
    public BreathingAct() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.")
    {
        
    }
    
    public void RunBreathe()
    {
        GetUserDuration();
        GetReady();
       
        while(Timer())
        {
            Console.Write($"\nBreathe in...");
            base.CountDown(4);
            Console.Write($"\nNow breathe out...");
            base.CountDown(6);
        }
        base.DisplayWellDone();

        
    }
}
