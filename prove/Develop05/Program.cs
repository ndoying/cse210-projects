using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            // Handle the exception.
        }    
    
        bool _continueRunning = true;

        //Initiate the Goals Class
        
        Goals goalsInstance = new Goals("Default Type", "Default Name", "Default Desc", 0, false);
        
        //Main Menu
        while (_continueRunning)
        {
            Console.WriteLine($"\nYou have {Goals.GetTotal()} points");

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu >> ");

            int _userInput = int.Parse(Console.ReadLine());

            //Switch statement to initiate and run the respective menu options
            switch (_userInput)
            {
                case 1: //Create a new goal
                    Console.WriteLine("\nThe goal types are::");
                    Console.WriteLine("1. A simple goal");
                    Console.WriteLine("2. An eternal goal");
                    Console.WriteLine("3. A checklist goal");
                    Console.Write("What type of goal would you like to set? >> ");

                    int _userInput2 = int.Parse(Console.ReadLine());
                    //Switch statement to specify the type of goal and instantiate that goal type's class
                    switch (_userInput2)
                    {
                        case 1:
                            SimpleGoal _simple = new SimpleGoal("SimpleGoal", "Default Name", "Default Desc", 0, false);
                            _simple.RunSimpleGoal();
                            break;
                        case 2:
                            EternalGoal _eternal = new EternalGoal("EternalGoal", "Default Name", "Default Desc", 0, false);
                            _eternal.RunEternalGoal();
                            break;
                        case 3:
                            CheckListGoal _checkList = new CheckListGoal("CheckListGoal", "Default Name", "Default Desc", 0, false, 0, 0, 0);
                            _checkList.RunCheckListGoal();
                        break;
                    }
                    break;
                case 2: //List Goals
                    Goals.DisplayGoals();
                    break;
                case 3: //Save Goals to File
                    Console.Write("Please give the text file a name: ");
                    string _userInput3 = (Console.ReadLine());
                    Goals.SaveFile(_userInput3);
                    break;
                case 4: //Load Goals from a File
                    Console.Write("What is the text file name? ");
                    string _userInput4 = (Console.ReadLine());
                    List<Goals> goalsList = Goals.ReadFile(_userInput4);
                    break;
                case 5: //Record an Event
                    Console.WriteLine("The goals are:");
                    Goals.DisplayGoals();
                    Console.Write("Which goal did you accomplish? >> ");
                    int accomplish = int.Parse(Console.ReadLine());

                    Goals selectedGoal = Goals.GetGoalAt(accomplish-1);

                    switch (selectedGoal)
                    {
                        case SimpleGoal simpleGoal:
                            simpleGoal.RecordEvent();

                            break;
                        case EternalGoal eternalGoal:
                            eternalGoal.RecordEvent();
    
                            break;
                        case CheckListGoal checkListGoal:
                            checkListGoal.RecordEvent();
                
                            break;
                        default:

                            break;
                    }
                    break;
                case 6: //Quit
                    _continueRunning = false;
                    break;
            }
        }
    }
}
