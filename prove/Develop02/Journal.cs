public class Journal
{
    public List<Entry> _entries = new List<Entry>(); // create a list to store the entries

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry); // add the entry to the list
    }
}