using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class SimpleGoal : Goals
{
    protected string _defaultType = "SimpleGoal";
    public override string GetType()
    {
        return _defaultType;
    }
    public SimpleGoal(string type, string name, string desc, int points, bool flag) : base(type, name, desc, points, flag)
    {
        
    }
    
    public void RunSimpleGoal()
    {
        CreateGoal();
        string theName = GetName();
        string theDesc = GetDesc();
        int thePoints = GetPoints();
        string theType = GetType();
        bool theFlag = GetFlag();

        SimpleGoal simpleGoal = new SimpleGoal(theType, theName, theDesc, thePoints, theFlag);

        AddGoal(simpleGoal);

    }

    public static SimpleGoal FromString(string str)
    {
    var parts = str.Split(",");
    return new SimpleGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
    }
    // public static SimpleGoal FromString(string str)
    // {
    //     var parts = str.Split(",");
    
    //     string _goalType = parts[0];
    //     string _goalName = parts[1];
    //     string  _goalDesc = parts[2];
    //     int _goalPoints = int.Parse(parts[3]);
    //     bool _completedFlag = bool.Parse(parts[4]);

    //     return new SimpleGoal(_goalType, _goalName, _goalDesc, _goalPoints, _completedFlag);
    
    // }
    public override void RecordEvent()
    {
        SetFlag(true);
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        RecordPoints(GetPoints());
    }

}


