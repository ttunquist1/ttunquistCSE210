class Outdoor : Event
{
    private string _weatherCondition;

    public Outdoor(string eventType, string title, string description, string date, string time, string address, string weatherCondition) : base(eventType, title, description, date, time, address)
    {
        _weatherCondition = weatherCondition;
    }

    
        public void displayOutdoorDetails()
        {
            displayFullDetails();
            Console.WriteLine($"Weather Condition: {_weatherCondition}");
        }
    
        



}