using System;

//This class controls the Reflecting activity using several methods from the base class.
public class ReflectionAct : Activities
{
    //Attributes are two lists.
    //Populating list of initial reflection prompts.
    private List<string> _reflectionPrompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    //Populating list of deeper questions for the reflection prompts
    private List<string> _deeperQuestions = new ()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself from this experience?",
        "How can you keep this experience in mind in the future?"
    };
    //Constructor to pass name and description parameters to the base class.
    public ReflectionAct() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }
    //Method to run the Reflection activity.
    public void RunReflect()
    {
        GetUserDuration();
        GetReady();

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {_reflectionPrompts[GetRandom(_reflectionPrompts.Count)]}---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string _userInput = Console.ReadLine();
        if (_userInput == "")
        {
            Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            CountDown(5);
        }
        //While loop calling the Timer function to control the duration of the activity.
        while(Timer())
        {
            Console.Write($"\n{_deeperQuestions[GetRandom(_deeperQuestions.Count)]} ");
            PauseSpinner(6);
        }
        DisplayWellDone();
    }
}