public class Resume
{
    //Responsibilities:
    //Keeps track of the person's name and a list of their jobs.
    public string _personName = "";
    public List<Job> _jobs = new List<Job>(); 

    //Behaviors:
    //Displays the resume, which shows the name first, followed by displaying each one of the jobs.
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobInformation();
        }
    }
}