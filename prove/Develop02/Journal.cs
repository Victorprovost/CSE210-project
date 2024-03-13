using System.Text.Json;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename, append: false))
        {
            foreach (var entry in _entries)
            {
                sw.WriteLine($"{entry.Date}, {entry._promptText}, {entry._EntryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        try
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(',');
                    var entry = new Entry(line[0], line[1], line[2]);
                    _entries.Add(entry);
                }
            }
        }

        catch (Exception e)
        {
            Console.WriteLine($"Error loading file:  { e.Message}");
        }
    }

    public void SaveToJson(string filename)
    {
        string jsonSring = JsonSerializer.Serialize(_entries);
        File.WriteAllText(filename, jsonSring);
    }

    public void LoadFromJson(string filename)
    {
        try
        {
            string jsonString = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading file JSON:  {e.Message}");
        }
    }
}    