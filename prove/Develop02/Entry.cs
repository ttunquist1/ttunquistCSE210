public class Entry
{
    // get random prompt
    PromptGenerator promptGenerator = new PromptGenerator();
    // create variables
    public DateTime _date;
    public string _entry;
    public string _prompt;


    // void print method
    public void Displayprompt()
    {
        _prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"{_prompt}\n");
    }
    // create entry
    public void CreateEntry()
    {
        _entry = Console.ReadLine();
    }
    // void print method
    public void DisplayEntry()
    {
        _date = DateTime.Now;
        Console.WriteLine($"{_date} -- {_prompt}\n{_entry}\n");
    }
}