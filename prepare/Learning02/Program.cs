using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a new job instance
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //Create a second new job instance
        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Create a resume instance
        Resume myResume = new Resume();
        myResume._name = "Alison Rose";
        
        //Create a list of job objects
        List<Job> _jobs = new List<Job>();

        //Add job objects to list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Method to display resume details
        myResume.DisplayResumeDetails();

        
    }
}