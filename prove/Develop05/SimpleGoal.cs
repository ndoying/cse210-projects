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

    public override void RecordEvent()
    {
        SetFlag(true);
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        RecordPoints(GetPoints());
    }

}