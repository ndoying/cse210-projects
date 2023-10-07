using System;

public class Prompt
{

    //Declare a List<string>
    public List<string> _promptList {get; set;}

    //Initialize the list 
    public Prompt()
    {
        _promptList = new List<string>();

        //Populate the list PromptList
        _promptList.Add("Who was the most interesting person I interacted with today?");
        _promptList.Add("What was the best part of my day?");
        _promptList.Add("How did I see the hand of the Lord in my life today?");
        _promptList.Add("What was the strongest emotion I felt today?");
        _promptList.Add("If I had one thing I could do over, what would it be?");
        _promptList.Add("Who should I thank today?");
        _promptList.Add("Who helped me today?");
        _promptList.Add("Who did I help today?");
        _promptList.Add("What did I learn today?");
        _promptList.Add("What was the most interesting thing I saw today?");
    }

    //Method to display a prompt from the list _promptList
    public string GetPrompt()
    {
        //Creating an instance from class Randomizer
        Randomizer _randomIndex = new Randomizer();
        int minValue = 0;
        int maxValue = 10;
        int _indexNumber = _randomIndex.CreateRandomNumber(minValue, maxValue);
        string _promptToDisplay = _promptList[_indexNumber];
        return _promptToDisplay;
    }
   
}