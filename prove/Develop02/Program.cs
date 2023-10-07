using System;

class Program
{

    static void Main(string[] args)
    {
        bool _continueRunning = true;

        Prompt _thePrompts = new Prompt();
        Journal _userEntry = new Journal();

        while (_continueRunning)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please Select one of the following options:");
            Console.WriteLine("[1] Write");
            Console.WriteLine("[2] Display");
            Console.WriteLine("[3] Load");
            Console.WriteLine("[4] Save");
            Console.WriteLine("[5] Quit");
            Console.Write("What would you like to do? \n>>");

            int _userInput = int.Parse(Console.ReadLine());

            
            if (_userInput == 1)
            {
                // Ask user for journal entry and save as _userResponse
                string _prompt = _thePrompts.GetPrompt();
                Console.WriteLine(_prompt);
                Console.Write(">>");
                string _userResponse = Console.ReadLine();

                // Generate a date for the journal entry
                DateTime theCurrentTime = DateTime.Now;
                string _dateText = theCurrentTime.ToShortDateString();

                // Create full journal entry with date, prompt and response
                string _journalEntry = _dateText + " " + _prompt + " " + _userResponse;

                // Create Journal Entry
                _userEntry.AddItemToList(_journalEntry);
                  
            }
            else if (_userInput == 2)
            {
                // Call method to display the entries in the journal list
                _userEntry.DisplayJournal();

            }
            else if (_userInput == 3)
            {
                // Ask user for file name and call method to load the file
                Console.Write("What is the file name? \n>>");
                string _fileName = Console.ReadLine();
                _userEntry.LoadJournal(_fileName);
            }
            else if (_userInput == 4)
            {
                // Ask user for file name and call method to save the file
                Console.Write("What is the file name? \n>>");
                string _fileName = Console.ReadLine();
                Console.Write($"Do you need to load the existing file: {_fileName} first (y/n)? \n>>");
                string _answer = Console.ReadLine();
                if (_answer == "y")
                {
                    _userEntry.LoadJournal(_fileName);
                    _userEntry.SaveJournal(_fileName);
                }
                else
                {
                _userEntry.SaveJournal(_fileName);
                }
            }
            else
            {
                // Quit the program
                _continueRunning = false;
            }        
             
        } 

    }
}