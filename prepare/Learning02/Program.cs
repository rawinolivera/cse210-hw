using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Support Specialist";
        job1._company = "ASOV";
        job1._startYear = 2015;
        job1._endYear = 2016;

        //job1.DisplayJob();

        Job job2 = new Job();
        job2._jobTitle = "Assistant";
        job2._company = "ANKA ANDINA";
        job2._startYear = 2016;
        job2._endYear = 2022;

        //job2.DisplayJob();
        Console.WriteLine("");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("");

        Resume resume = new Resume();
        resume._personName = "Anthony Rafael";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
        Console.WriteLine();
    }
}