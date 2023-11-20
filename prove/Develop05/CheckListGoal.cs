using System;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class CheckListGoal : Goals
{
    protected int _goalFrequency;
    private int _timesAccomplished;
    private int _bonusPoints;
    public int GetFrequency()
    {
        return _goalFrequency;
    }

    public int GetBonus()
    {
        return _bonusPoints;
    }
    protected string _defaultType = "CheckListGoal";
    public override string GetType()
    {
        return _defaultType;
    }
    public int GetTimes()
    {
        return _timesAccomplished;
    }
    public CheckListGoal(string type, string name, string desc, int points, bool flag, int frequency, int times, int bonus) : base(type, name, desc, points, flag)
    {
        _goalFrequency = frequency;
        _timesAccomplished = times;
        _bonusPoints = bonus;
    }
    
    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.WriteLine("\nHow many times will you do this goal?");
        _goalFrequency = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points for this goal?: ");
        _bonusPoints = int.Parse(Console.ReadLine());   
    }
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

    public override void RecordEvent()
    {
        SetFlag(false);
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        RecordPoints(GetPoints());
        _timesAccomplished = _timesAccomplished + 1;
        if (_timesAccomplished == _goalFrequency)
        {
            Console.WriteLine($"Congratulations! You have earned {GetBonus()} points!");
            RecordPoints(GetBonus());
        }
    }

}
