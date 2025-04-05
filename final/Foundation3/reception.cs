class Receptions : Event
{
    private string _email { get; set; }

    public Receptions(string title, string description, string date, string time, string address, string eventType, string email) : base(title, description, date, time, address, eventType)
    {
        _email = email;
    }
    public void displayReceptionDetails()
    {
        displayFullDetails();
        Console.WriteLine($"Email: {_email}");
    }
}