//You program should contain two classes one for a Job and one for the Resume itself, as follows:
public class Job
{
    //Responsibilities:
    //Keeps track of the company, job title, start year, and end year.
    public string _company = "";
    public string _jobTitle = "";
    public string _startYear = "";
    public string _endYear = "";

    //Behaviors:
    //Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: 
    //"Software Engineer (Microsoft) 2019-2022".
    public void DisplayJobInformation()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}