using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool _continueRunning = true;

        //Initiate the Goals Class
        // Goals _goal = new Goals("Default Name", "Default Description");
        Goals goalsInstance = new Goals("Default Type", "Default Name", "Default Desc", 0, false);

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

            //Switch statement using the menu options to initiate and run the respective mindfulness activities
            switch (_userInput)
            {
                case 1: //Create a Goal
                    Console.WriteLine("\nThe goal types are::");
                    Console.WriteLine("1. A simple goal");
                    Console.WriteLine("2. An eternal goal");
                    Console.WriteLine("3. A checklist goal");
                    Console.Write("What type of goal would you like to set? >> ");

                    int _userInput2 = int.Parse(Console.ReadLine());

                    switch (_userInput2)
                    {
                        case 1:
                            
                            SimpleGoal _simple = new SimpleGoal("Default Type", "Default Name", "Default Desc", 0, false);
                            _simple.RunSimpleGoal();
                            break;
                        case 2:
                            Console.WriteLine("You chose an enternal goal");
                            break;
                        case 3:
                            Console.WriteLine("You chose a checklist goal");
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
                case 4: //Load Goals from File
                    Console.Write("What is the text file name: ");
                    string _userInput4 = (Console.ReadLine());
                    List<Goals> goalsList = Goals.ReadFile(_userInput4);
                    break;
                case 5: //Record and Event
                    goalsInstance.RecordEvent();
                    break;
                case 6: //Quit
                    _continueRunning = false;
                    break;
            }
        }
    
    }
}