using System;

public class Activities
{
   private string _activityChoice;
   protected int _activityDuration;
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

   public void StartBreathingActivity()
   {
        BreathingAct _theBreathe = new BreathingAct();
        _theBreathe.GetName();
        _theBreathe.GetDescription();
        _theBreathe.DisplayStartMessage();
        // _theBreathe.GetUserDuration();
        _theBreathe.RunBreathe();
        
   }

   public void DisplayStartMessage()
   {
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
        Console.WriteLine($"{_activityDesc}\n");
        // Console.Write("How long, in seconds, would you like for your session?>>");
   }

   public int GetUserDuration()
   {
        Console.Write("How long, in seconds, would you like for your session?>>");
        int _activityDuration = int.Parse(Console.ReadLine());
        return _activityDuration;
   }

   public void GetReady()
   {
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
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);
        Console.Write(_activityDuration);

        DateTime currentTime = DateTime.Now;
        return currentTime < futureTime; 
   }

   public void DisplayWellDone()
   {
        Console.WriteLine("Well done!!");
        PauseSpinner();
   }

}