class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save()
    {
        List<string> entryStrings = new List<string>();

        foreach (Entry entry in _entries)
        {
            string entryString = $"{entry._date} | {entry._prompt} | {entry._text} | {entry._readBom}";
            entryStrings.Add(entryString);
        }

        File.WriteAllLines("journal.txt", entryStrings);
    }

    public void Load()
    {
        List<string> lines = File.ReadAllLines("journal.txt").ToList();
        
        _entries.Clear();

        foreach (string line in lines)
        {
            List<string> parts = line.Split('|').ToList();

            if (parts.Count == 4)
            {
                string date = parts[0];
                string prompt = parts[1];
                string text = parts[2];
                string readBom = parts[3];
                
                Entry entry = new Entry(date, prompt, text, readBom);
                _entries.Add(entry);
            }
        }
    }
}