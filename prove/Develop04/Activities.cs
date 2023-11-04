using System;

public class Activities
{
   //This class has the following attributes and then an number of methods used in common by some or all of the classes in the Mindfulness program.
   private int _activityDuration;
   private DateTime _startTime;
   protected string _activityName;
   protected string _activityDesc; 

   //Constructor to get the name and description of each activity
   public Activities(string defaultName, string defaultDesc)
    {
        _activityName = defaultName;
        _activityDesc = defaultDesc;
    }
    //Method to get the name of the activity
    public string GetName()
    {
        return _activityName;
    }
    //Method to get the description of the activity
    public string GetDescription()
    {
        return _activityDesc;
    }
   //Method to display the name and description of each activity
   public void DisplayStartMessage()
   {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
        Console.WriteLine($"{_activityDesc}\n");
   }
   //Method that prompts the program user for the desired activity duration in seconds and returns it for use in the Tiner method.
   public int GetUserDuration()
   {
        Console.Write("How long, in seconds, would you like for your session?>>");
        this._activityDuration = int.Parse(Console.ReadLine());
        this._startTime = DateTime.Now;
        return _activityDuration;
   }
   //Method to display a get ready message and a calls the PauseSpinner method
   public void GetReady()
   {
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseSpinner();
   }
   //Method that creates a list for the spinner animation and controls the duration of the spinner
   public void PauseSpinner()
   {
        List<string> spinners = new List<string>();
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        spinners.Add("-");
        spinners.Add("|");
        spinners.Add("/");
        spinners.Add("-");
        spinners.Add("\\");
        spinners.Add("-");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinners[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= spinners.Count)
            {
                i = 0;
            }
        }
   }
   //Method to display a count down in seconds with the value set when the method is called.
   public void CountDown(int value)
   {
        int _seconds = value;
        for (int i = _seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
   }
   //Method to return a true/false flag used to control the time of the activity.
   public bool Timer()
   {
        DateTime currentTime = DateTime.Now;
        TimeSpan elasped = currentTime - _startTime;

        return elasped.TotalSeconds < _activityDuration;
   }
   //Method to display an encouraging completion message calling the PauseSpinner method twice.
   public void DisplayWellDone()
   {
        Console.WriteLine("\n\nWell done!!");
        PauseSpinner();
        Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_activityName} Activity.");
        PauseSpinner();
        Console.Clear();
   }
   //Method to return a random number between zero and the maximum number based on a value provided when the method is called.
   public int GetRandom(int maxValue)
   {
          Random random = new Random();
          int _minValue = 0;
          int _maxValue = maxValue;
          int _indexNumber = random.Next(_minValue, _maxValue);
          return _indexNumber;
   }

}