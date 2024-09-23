using System.Collections.Generic;
public class Resume
{
    // varable for name
    public string _name;

    // list of all the jobs
    public List<Job> _jobLis= new List<Job>();

    public void DisplayResume()
    {
        // write Name: name and then starts the job list
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // calls the DisplayJob function in each job in the _jobLis
        foreach (Job job in _jobLis)
        {
            job.DisplayJobs();
        }
    }
}