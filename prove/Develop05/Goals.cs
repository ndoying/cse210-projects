using System;
using System.Security.Cryptography.X509Certificates;

public class Goals
{
 private string _goalName;
 private string _goalDesc;
 private int _goalPoints; 
 private string _goalType;
 private bool _completedFlag;

 private static int _totalPoints = 0;


//Declaring and initializing the goal list
 private static List<Goals> goalList = new List<Goals>();

 //Method to create a goal with the inputs from the user
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

public static Goals GetGoalAt(int index)
{
    return goalList[index];
}

//Method to display the goals from the list
 public static void DisplayGoals()
 {
    for (int i = 0; i < goalList.Count; i++)   
    {
         Goals goal = goalList[i];
         if (goal != null) // Add this condition to check if the goal is not null
         {
            if (goal._completedFlag is true)
            {
               Console.WriteLine($"[{i + 1}]. [X] {goal.GetName()} ({goal.GetDesc()})");
            }
            else
            {
               Console.WriteLine($"[{i + 1}]. [ ] {goal.GetName()} ({goal.GetDesc()})");
            }
         }
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
            string goalString;
            if (goal is CheckListGoal checkListGoal)
            {
               goalString = $"{goal.GetType()},{goal.GetName()},{goal.GetDesc()},{goal.GetPoints()},{goal.GetFlag()},{checkListGoal.GetFrequency()},{checkListGoal.GetBonus()}";
            }
            else
            {
               goalString = $"{goal.GetType()},{goal.GetName()},{goal.GetDesc()},{goal.GetPoints()},{goal.GetFlag()}";
            }
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
    goalList.Clear();
   //  goalList = new List<Goals>();
   

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
// public static SimpleGoal FromString(string str)
// {
//    Make virtual??
// }

//Method to record an event
public virtual void RecordEvent()
{
   //  Console.WriteLine("The goals are:");
   //  DisplayGoals();
   //  Console.Write("Which goal did you accomplish? >> ");
   //  int accomplish = int.Parse(Console.ReadLine());


   //  Goals selectedGoal = goalList[accomplish-1];

   //  switch (selectedGoal)
   //      {
   //          case SimpleGoal simpleGoal:
   //             simpleGoal.RecordEvent();

   //             break;
   //          case EternalGoal eternalGoal:
   //             eternalGoal.RecordEvent();
    
   //             break;
   //          case CheckListGoal checkListGoal:
   //             checkListGoal.RecordEvent();
                
   //              break;
   //          default:
                
   //              break;
   //      }
    
}
public static void RecordPoints(int points2)
{
    _totalPoints = _totalPoints + points2;
    Console.WriteLine($"You now have {_totalPoints} points");
}
}
