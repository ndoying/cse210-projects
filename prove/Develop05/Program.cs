using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool _continueRunning = true;

        //Initiate the Goals Class
        // Goals _goal = new Goals("Default Name", "Default Description");
        

        while (_continueRunning)
        {
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
                case 1:
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
                case 2:
                    Goals.DisplayGoals();
                    break;
                case 3:
                    Console.WriteLine("Please give the text file a name: ");
                    string _userInput3 = (Console.ReadLine());
                    Goals.SaveFile(_userInput3);
                    break;
                case 4:
                    Console.WriteLine("What is the text file name: ");
                    string _userInput4 = (Console.ReadLine());
                    Goals goalsInstance = new Goals("Default Type", "Default Name", "Default Desc", 0, false);
                    List<Goals> loadedGoals = goalsInstance.ReadFile(_userInput4);
                    break;
                case 5:
                    Goals.RecordEvent();
                    break;
                case 6:
                    _continueRunning = false;
                    break;
            }
        }
    
    }
}