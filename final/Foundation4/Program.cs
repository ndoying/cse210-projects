using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        List<Activity> activities = new List<Activity>();

        DateTime aDate1 = new DateTime(2023, 1, 1, 12, 00, 0);
        string date1 = aDate1.ToString("dd MMM yyyy");
        Running a1 = new Running(date1, 30, 3.5);
        activities.Add(a1);

        DateTime aDate2 = new DateTime(2023, 6, 15, 12, 00, 0);
        string date2 = aDate2.ToString("dd MMM yyyy");
        Cycling c1 = new Cycling(date2, 30, 20);
        activities.Add(c1);

        DateTime aDate3 = new DateTime(2023, 12, 31, 12, 00, 0);
        string date3 = aDate3.ToString("dd MMM yyyy");
        Swimming s1 = new Swimming(date3, 30, 60);
        activities.Add(s1);

        foreach (Activity a in activities)
        {
            // string date = a.GetDate();

            // int duration = a.GetDuration();

            // double speed = a.GetSpeed();

            // double pace = a.GetPace();

            Console.WriteLine(a.GetSummary());
        }
        Console.WriteLine();
    }
}