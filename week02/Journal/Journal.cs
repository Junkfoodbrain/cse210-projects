using System.IO;


public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        Entry entry = new Entry();
        entry._date = newEntry._date;
        entry._promptText = newEntry._promptText;
        entry._entryText = newEntry._entryText;
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        //adding small reminder to user to load a file so they can view or add entries.
        if (_entries == null || _entries.Count == 0)
        {
            Console.WriteLine("Please load a file first.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)
    {
        if (_entries == null) return;
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                string line = $"{e._date}~~{e._promptText}~~{e._entryText}";
                outputFile.WriteLine(line);
            }
        }

    }

    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();
        if (!File.Exists(file)) return;
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] {"~~"}, StringSplitOptions.None);
            if (parts.Length >= 3)
            {
                Entry e = new Entry();
                e._date = parts[0];
                e._promptText = parts[1];
                e._entryText = parts[2];
                _entries.Add(e);
            }
        }

    }

}