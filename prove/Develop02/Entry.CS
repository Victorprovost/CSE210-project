
public class Entry
{
    private DateTime now;
    private string promt;
    private string response;

    public string Date { get; }
    public string _promptText { get; }
    public string _EntryText { get; }

    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        _promptText = promptText;
        _EntryText = entryText;
    }

    public Entry(DateTime now, string promt, string response)
    {
        this.now = now;
        this.promt = promt;
        this.response = response;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}\nPrompt: {_promptText}\nEntry: {_EntryText}\n");
    }
}    