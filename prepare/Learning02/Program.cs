using System;

partial class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "software engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Victor Provost";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        foreach (Job job in myResume._jobs)
        {
            job.DisplayJobDetails();
            Console.WriteLine();
        }
    }
}