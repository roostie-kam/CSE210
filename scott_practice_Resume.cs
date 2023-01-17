using System;

public class Resume
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        Console.WriteLine("Title:");

        // Notice the use of the custom data type "Job" in this loop.
        foreach (Job job in _jobs)
        foreach (Title title in _title)

        {
            // This calls the Display method on each job or title.
            job.Display();
            title.Display();

        }
    }
}