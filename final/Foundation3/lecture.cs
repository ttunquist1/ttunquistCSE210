class Lectures : Event
{
    private string _speaker { get; set; }
    private int _capacity { get; set; }

    public Lectures(string title, string description, string date, string time, string address, string eventType, string speaker, int capacity) : base(title, description, date, time, address, eventType)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void displayLectureDetails()
    {
        displayFullDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}