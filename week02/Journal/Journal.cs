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
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)
    {

    }
    
    public void LoadFromFile(string file)
    {
        
    }
    
}