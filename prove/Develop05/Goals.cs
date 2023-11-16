using System;
using System.Security.Cryptography.X509Certificates;

public class Goals
{
 private string _goalName;
 private string _goalDesc;
 private int _goalPoints; 
 private string _goalType;
 private bool _completedFlag;

 private static int _totalPoints;

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
    _totalPoints = 0;
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
 public static int GetTotal()
 {
    return _totalPoints;
 }
 public static void SetTotal(int points3)
 {
    _totalPoints = points3;
 }
//Method to create a list of the goal instances
public static void AddGoal(Goals goal)
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
        outputFile.WriteLine(_totalPoints);

        foreach (Goals goal in goalList)
        {
            string goalString = $"{goal.GetType()},{goal.GetName()},{goal.GetDesc()},{goal.GetPoints()}, {goal.GetFlag()}";
            outputFile.WriteLine(goalString);
        }
    }
 }
//Method to read the text file of goals into an array of strings and then into a list.
public static List<Goals> ReadFile(string filename)
{
    // if (!File.Exists(filename))
    //     return null;
    
    // List<Goals> goalList = new List<Goals>();
    goalList = new List<Goals>();

    using StreamReader reader = new StreamReader(filename);
    _totalPoints = int.Parse(reader.ReadLine());
    Goals.SetTotal(_totalPoints);
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        var parts = line.Split(",");
        Goals item;
        switch (parts[0])
        {
            case "SimpleGoal":
                item = SimpleGoal.FromString(line);
                break;
            case "EternalGoal":
                item = null;
                break;
            case "CheckListGoal":
                item = null;
                break;
            default:
                item = null;
                break;
        }
        AddGoal(item);
    }
    return goalList;
    

}
public static SimpleGoal FromString(string str)
{
    var parts = str.Split(",");
    
    string _goalType = parts[0];
    string _goalName = parts[1];
    string  _goalDesc = parts[2];
    int _goalPoints = int.Parse(parts[3]);
    bool _completedFlag = bool.Parse(parts[4]);

    return new SimpleGoal(_goalType, _goalName, _goalDesc, _goalPoints, _completedFlag);
    
}

//Method to record an event
public virtual void RecordEvent()
{
    Console.WriteLine("The goals are:");
    DisplayGoals();
    Console.Write("Which goal did you accomplish? >> ");
    int accomplish = int.Parse(Console.ReadLine());

    // Console.WriteLine(accomplish); //Check
    // Console.WriteLine(goalList[accomplish-1]); //Check

    Goals selectedGoal = goalList[accomplish-1];

    switch (selectedGoal)
        {
            case SimpleGoal simpleGoal:
                simpleGoal.RecordEvent();

                break;
            // case EternalGoal eternalGoal:
    
            //     break;
            // case CheckListGoal checkListGoal:
                
            //     break;
            default:
                
                break;
        }
    
}
public static void RecordPoints(int points2)
{
    _totalPoints = _totalPoints + points2;
    Console.WriteLine($"You now have {_totalPoints} points");
}
}


