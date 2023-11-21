using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class EternalGoal : Goals
{
    //Set goal type for class object
    protected string _defaultType = "EternalGoal";
    public override string GetType()
    {
        return _defaultType;
    }
    //Constructor to assign values the class' variables
    public EternalGoal(string type, string name, string desc, int points, bool flag) : base(type, name, desc, points, flag)
    {
        
    }
    //Method to instantiate an object of this class and add it to the goal list
    public void RunEternalGoal()
    {
        CreateGoal();
        string theName = GetName();
        string theDesc = GetDesc();
        int thePoints = GetPoints();
        string theType = GetType();
        bool theFlag = GetFlag();

        EternalGoal eternalGoal = new EternalGoal(theType, theName, theDesc, thePoints, theFlag);

        AddGoal(eternalGoal);
    }
    //Mehod to instantiate an object from a text file string
    public static EternalGoal FromString(string str)
    {
        var parts = str.Split(",");
        return new EternalGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
    }
    //Override method to record an event and record points earned
    public override void RecordEvent()
    {
        SetFlag(false);
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        RecordPoints(GetPoints());
    }
}