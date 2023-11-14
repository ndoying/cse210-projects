using System;
using System.Security.Cryptography.X509Certificates;

public class Goals
{
 private string _goalName;
 private string _goalDesc;
 private int _goalPoints; 
 private string _goalType;
 private bool _completedFlag;

//Declaring and initializing the goal list
 private static List<Goals> goalList = new List<Goals>();

 //Method to create a goal with the inputs from the user
 public void CreateGoal()
 {
    _goalType = "default value";
    Console.WriteLine("\nWhat is the name of your goal?");
    _goalName = Console.ReadLine();
    Console.WriteLine("Describe your goal: ");
    _goalDesc = Console.ReadLine();
    Console.WriteLine("How many points is this goal worth? ");
    _goalPoints = int.Parse(Console.ReadLine());
 
 }
 //Constructor to set the variables
 public Goals(string type, string name, string desc, int points, bool flag)
 {
    this._goalType = type;
    this._goalName = name;
    this._goalDesc = desc;
    this._goalPoints = points;
    this._completedFlag = flag;
 }
 //Getters and setters for the variables 
 public string GetName()
 {
    return _goalName;
 }
 public void SetName(string name)
 {
    _goalName = name;
 }
 public string GetDesc()
 {
    return _goalDesc;
 }
 public void SetDesc(string desc)
 {
    _goalDesc = desc;
 }
 public int GetPoints()
 {
    return _goalPoints;
 }
 public void SetPoints(int points)
 {
    _goalPoints = points;
 }

 public new virtual string GetType()
 {
    return _goalType;
 }

 public bool GetFlag()
 {
    return _completedFlag;
 }

 public void SetFlag(bool flag)
 {
    _completedFlag = flag;
 }
//Method to create a list of the goal instances
public void AddGoal(Goals goal)
{
    goalList.Add(goal);
}
// //  public void CreateRepresentation(string theObject, string theName, string theDesc, int thePoints)
// //  {
// //     string _representation = $"{theObject}:{theName},{theDesc},{thePoints}";
// //     goalList.Add(new Goals(theName, theDesc, thePoints));
// //     Console.WriteLine($"{_representation}");
//  }
//Method to display the goals from the list
 public static void DisplayGoals()
 {
    for (int i = 0; i < goalList.Count; i++)   
    {
         Goals goal = goalList[i];
         Console.WriteLine($"[{i + 1}]. [ ] {goal.GetName()} ({goal.GetDesc()})");
    }
 }
//Method to save the goals from the list into a text file
 public static void SaveFile(string filename)
 {
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        foreach (Goals goal in goalList)
        {
            string goalString = $"{goal.GetType()},{goal.GetName()},{goal.GetDesc()},{goal.GetPoints()}, {goal.GetFlag()}";
            outputFile.WriteLine(goalString);
        }
    }
 }
//Method to read the text file of goals into an array of strings
public List<Goals> ReadFile(string filename)
{
    string _fileName = filename;
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach(string line in lines)
    {
        string[] parts = line.Split(",");
        string _goalType = parts[0];
        string _goalName = parts[1];
        string  _goalDesc = parts[2];
        int _goalPoints = int.Parse(parts[3]);
        bool _completedFlag = bool.Parse(parts[4]);

        Goals goal = new Goals(_goalType, _goalName, _goalDesc, _goalPoints, _completedFlag);
        goalList.Add(goal);
    }
    return goalList;
}


//Method to record an event
 public static void RecordEvent()
 {
    Console.WriteLine("The goals are:");
    DisplayGoals();
    Console.WriteLine("Which goal did you accomplish? >> ");
    int accomplish = int.Parse(Console.ReadLine());

    Console.WriteLine(accomplish); //Check
    Console.WriteLine(goalList[accomplish-1]); //Check
    
    if(accomplish >= 1 && accomplish <= goalList.Count)
    {
        Goals selectedGoal = goalList[accomplish-1];

        if(selectedGoal is SimpleGoal)
        {
            SimpleGoal simpleGoal = (SimpleGoal)selectedGoal;
            simpleGoal.SetFlag(true);
        }
    // else if(_goalType is EternalGoal)
    // {

    // }
    // else if(_goalType is CheckListGoal)
    // {

    // }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
    else
    {
        Console.WriteLine("Invalid goal selection.");
    }

  }
}


