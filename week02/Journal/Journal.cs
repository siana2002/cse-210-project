using System;

public class Journal
{
    public List<Entry> _entry = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entry.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entry)
        {
            e.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entry)
            {
                outputFile.WriteLine($" {e._date} | {e._promptText} | {e._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entry.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entry.Add(entry);
        }   
    }
}