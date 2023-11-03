using System;

public class Activities
{
   private int _randomIndex;
   protected int _activityDuration;
   private DateTime _startTime;
   protected string _activityName;
   protected string _activityDesc; 

   public Activities(string defaultName, string defaultDesc)
    {
        _activityName = defaultName;
        _activityDesc = defaultDesc;

    }

    public string GetName()
    {
        return _activityName;
    }

    public string GetDescription()
    {
        return _activityDesc;
    }

   public void DisplayStartMessage()
   {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
        Console.WriteLine($"{_activityDesc}\n");
   }

   public int GetUserDuration()
   {
        Console.Write("How long, in seconds, would you like for your session?>>");
        this._activityDuration = int.Parse(Console.ReadLine());
        this._startTime = DateTime.Now;
        return _activityDuration;

   }

   public void GetReady()
   {
        Console.Clear();
        Console.WriteLine("Get ready...");
        // Thread.Sleep(5000);
        PauseSpinner();
   }

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

   public bool Timer()
   {
        DateTime currentTime = DateTime.Now;
        TimeSpan elasped = currentTime - _startTime;

        return elasped.TotalSeconds < _activityDuration;
   }

   public void DisplayWellDone()
   {
        Console.WriteLine("\n\nWell done!!");
        PauseSpinner();
        Console.WriteLine($"\nYou have completed another {_activityDuration} seconds of the {_activityName} Activity.");
        Thread.Sleep(4000);
        Console.Clear();
   }

   public int GetRandom(int maxValue)
   {
          Random random = new Random();
          int _minValue = 0;
          int _maxValue = maxValue;
          int _indexNumber = random.Next(_minValue, _maxValue);
          return _indexNumber;
   }

}