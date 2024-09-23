using System;

class Program
{
    static void Main(string[] args)
    {
        //first time writing codes for Class
        // Adding new job, writing it down
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2017;
        job1._endYear = 2019;

        // Second Job varibles
        Job job2 = new Job();
        job2._jobTitle = "Desk Assistant";
        job2._companyName = "Apple";
        job2._startYear = 2020;
        job2._endYear= 2024;

        // display jobs
        // job1.DisplayJobs();
        // job2.DisplayJobs();

        // started new class, Resume. Added "my" name, and added job1 and job2 to the list
        Resume myResume = new Resume();
        myResume._name = "Samuel Davidson";
        myResume._jobLis.Add(job1);
        myResume._jobLis.Add(job2);
        
        // Display the jobs things
        myResume.DisplayResume();
    }
}