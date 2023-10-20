using System;

class Program
{
    static void Main(string[] args)
    {
        //ceate an instance of the Scripture class and provide the scripture string
        Scripture _text1 = new Scripture("I have fought the good fight, I have finished my course, I have kept the faith.");
        
        //create an instance of the Reference class and provide the reference
        Reference ref1 = new Reference("2 Timothy", "4", "7");

        //call method in Scripture class to split the scripture string into words
        _text1.SplitPhrase();
        
        //do-while loop to iterate each time the enter key is pressed and hide words
        // and display the scripture
        do
        {
            //clearing the screen
            Console.Clear();
            //call method in Reference class to display the reference
            ref1.DisplayRef();
            //call method in Scripture class to display the scripture 
            _text1.DisplayWords();
            //prompt for user input
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
        
            string userInput = Console.ReadLine();
            bool _hiddenFlag = _text1.IsCompletelyHidden();
            //quits the program if all word are hidden
            if (_hiddenFlag == true)
            {
                break;
            }
            //quits the program if user types 'quit'
            else if (userInput.ToLower() == "quit")
            {
                break; // exit loop and end program
            }
            //hides more words if the user presses the enter key
            else if (userInput == "")
            {
                
                _text1.HideWords();
            }
        } while (true);
    }
}