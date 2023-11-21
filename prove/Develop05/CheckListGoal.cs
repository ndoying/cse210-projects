using System;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class CheckListGoal : Goals
{
    //Field declarations
    protected int _goalFrequency;
    private int _timesAccomplished;
    private int _bonusPoints;
    //Set goal type for class object
    protected string _defaultType = "CheckListGoal";
    public override string GetType()
    {
        return _defaultType;
    }

    //Getters and Setters
    public int GetFrequency()
    {
        return _goalFrequency;
    }
    public int GetBonus()
    {
        return _bonusPoints;
    }
    public int GetTimes()
    {
        return _timesAccomplished;
    }

    //Constructor to assign values to the class' variables
    public CheckListGoal(string type, string name, string desc, int points, bool flag, int frequency, int times, int bonus) : base(type, name, desc, points, flag)
    {
        _goalFrequency = frequency;
        _timesAccomplished = times;
        _bonusPoints = bonus;
    }

    //Override method to add varibles to the Create Goal method
    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.WriteLine("\nHow many times will you do this goal?");
        _goalFrequency = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points for this goal?: ");
        _bonusPoints = int.Parse(Console.ReadLine());   
    }

    //Method to instantiate an object of this class and add it to the goal list
    public void RunCheckListGoal()
    {
        CreateGoal();
        string theName = GetName();
        string theDesc = GetDesc();
        int thePoints = GetPoints();
        string theType = GetType();
        bool theFlag = GetFlag();
        int theFrequency = GetFrequency();
        int theTimes = GetTimes();
        int theBonus = GetBonus();

        CheckListGoal checkGoal = new CheckListGoal(theType, theName, theDesc, thePoints, theFlag, theFrequency, theTimes, theBonus);

        AddGoal(checkGoal);
    }
    //Mehod to instantiate an object from a text file string
    public static CheckListGoal FromString(string str)
    {
        var parts = str.Split(",");
    
        string _goalType = parts[0];
        string _goalName = parts[1];
        string  _goalDesc = parts[2];
        int _goalPoints = int.Parse(parts[3]);
        bool _completedFlag = bool.Parse(parts[4]);
        int _goalFrequency = int.Parse(parts[5]);
        int _timesAccomplished = int.Parse(parts[6]);
        int _bonus = int.Parse(parts[7]);

        return new CheckListGoal(_goalType, _goalName, _goalDesc, _goalPoints, _completedFlag, _goalFrequency, _timesAccomplished, _bonus);
    
    }

    //Override method to record an event and record points earned
    public override void RecordEvent()
    {
        SetFlag(false);
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        RecordPoints(GetPoints());
        _timesAccomplished = _timesAccomplished + 1;
        if (_timesAccomplished == _goalFrequency)
        {
            Console.WriteLine($"Congratulations! You have earned {GetBonus()} BONUS points!");
            SetFlag(true);
            RecordPoints(GetBonus());

        }
    }
}
