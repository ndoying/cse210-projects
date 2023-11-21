using System;
using System.Security.Cryptography.X509Certificates;

public class Goals
{
//Field declarations
private string _goalName;
private string _goalDesc;
private int _goalPoints; 
private string _goalType;
private bool _completedFlag;
private static int _totalPoints = 0;

//Declaring and initializing the goal list
 private static List<Goals> goalList = new List<Goals>();

 //Method to create a goal with the inputs from the user
 //Virtual so other classes can add variables
 public virtual void CreateGoal()
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
 public string GetDesc()
 {
    return _goalDesc;
 }
 public int GetPoints()
 {
    return _goalPoints;
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
//Method to retrieve a Goals object from list based on specified index
public static Goals GetGoalAt(int index)
{
    return goalList[index];
}
//Method to display the goals from the list and mark as completed if they have been completed
 public static void DisplayGoals()
 {
   Console.WriteLine("The goals are:");
    for (int i = 0; i < goalList.Count; i++)   
    {
         Goals goal = goalList[i];
         if (goal != null) // Check if the goal is not null
         {
            if (goal._completedFlag is true)
            {
               if (goal is CheckListGoal checkListGoal)
               {
                  Console.WriteLine($"[{i + 1}]. [X] {goal.GetName()} ({goal.GetDesc()}) -- Currently completed {checkListGoal.GetTimes()}/{checkListGoal.GetFrequency()}");
               }
               else
               {
                  Console.WriteLine($"[{i + 1}]. [X] {goal.GetName()} ({goal.GetDesc()})");
               }
            }
            else
            {
               if (goal is CheckListGoal checkListGoal)
               {
                  Console.WriteLine($"[{i + 1}]. [ ] {goal.GetName()} ({goal.GetDesc()}) -- Currently completed {checkListGoal.GetTimes()}/{checkListGoal.GetFrequency()}");
               }
               else
               {
                  Console.WriteLine($"[{i + 1}]. [ ] {goal.GetName()} ({goal.GetDesc()})");
               }
            }
         }
    }
 }

//Method to save total points earned and the goals from the goal list into a text file 
 public static void SaveFile(string filename)
 {
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        outputFile.WriteLine(_totalPoints);

        foreach (Goals goal in goalList)
        {
            string goalString;
            if (goal is CheckListGoal checkListGoal)
            {
               goalString = $"{goal.GetType()},{goal.GetName()},{goal.GetDesc()},{goal.GetPoints()},{goal.GetFlag()},{checkListGoal.GetFrequency()},{checkListGoal.GetTimes()},{checkListGoal.GetBonus()}";
            }
            else
            {
               goalString = $"{goal.GetType()},{goal.GetName()},{goal.GetDesc()},{goal.GetPoints()},{goal.GetFlag()}";
            }
            outputFile.WriteLine(goalString);
        }
    }
 }
//Method to read the text file of goals into an array of strings and then into a list
public static List<Goals> ReadFile(string filename)
{
    goalList.Clear();
   
    using StreamReader reader = new StreamReader(filename);
    _totalPoints = int.Parse(reader.ReadLine());
    Goals.SetTotal(_totalPoints); // Set the total points after reading from the file
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
                item = EternalGoal.FromString(line);
                break;
            case "CheckListGoal":
                item = CheckListGoal.FromString(line);
                break;
            default:
                item = null;
                break;
        }
        AddGoal(item);
    }
    return goalList;
    

}

//Method to record an event
public virtual void RecordEvent()
{
    //Method action at derived classes
}
//Method to record points earned by completing goals
public static void RecordPoints(int points2)
{
    _totalPoints = _totalPoints + points2;
    Console.WriteLine($"You now have {_totalPoints} points");
}
}
