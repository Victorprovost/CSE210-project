public class Job
{
    // Member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {
    }

    // Constructor
    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Method to display job details
    public void DisplayJobDetails()
    {
        Console.WriteLine("Company: " + _company);
        Console.WriteLine("Job Title: " + _jobTitle);
        Console.WriteLine("Start Year: " + _startYear);
        Console.WriteLine("End Year: " + _endYear);
    }
}
