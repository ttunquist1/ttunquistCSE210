
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private string _userFileName;

    public Journal()
    {

    }

    public void Display()
    {
        Console.WriteLine("\n************** Journal Entries **************");
        foreach (Entry Entry in _entries)
        {
            Entry.DisplayEntry();
        }
        Console.WriteLine("\n******************** End ********************");
    }

    public void CreateJournalFile()
    // Method to check if txt file is created if not create one
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            using(File.CreateText(_userFileName)){}
            Console.Write($"\n*** {_userFileName} has been created! ***\n");
            Console.Write("***  Your journal entries have been saved. ***\n");
            SaveJournalFile(_userFileName);
        }
        else
        {
            Console.Write($"\n*** {_userFileName} already exits. ***\n");
            Console.Write("***  Your journal entries have been added. ***\n");
            AppendJournalFile(_userFileName);
        }
    }

    public void SaveJournalFile(string _userFileName)
    // Method to save journal to txt file 
    {
        using (StreamWriter _outputFile = new StreamWriter(_userFileName))
        {
            foreach (Entry Entry in _entries)
            {
                _outputFile.WriteLine($"{Entry._date}; {Entry._prompt}; {Entry._entry}");
            }
        }
    }

    public void AppendJournalFile(string _userFileName)
    // Method to save a new entry to journal txt file 
    {
        using (StreamWriter _outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (Entry Entry in _entries)
            {
                _outputFile.WriteLine($"{Entry._date}; {Entry._prompt}; {Entry._entry}");
            }
        }
    }

    public void LoadJournalFile()
    // Method to check if txt file is created and load it into the list.  
    // This should replace any current info in the list
    {
        Console.Write("What your file name? ");
        string _userInput = Console.ReadLine();
        _userFileName = _userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("||");

                Entry entry = new Entry();

                entry._date = entries[0];
                entry._prompt = entries[1];
                entry._entry = entries[2];

                _entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine($"\n*** {_userFileName} does not exist. ***\n");
        }
    }

}