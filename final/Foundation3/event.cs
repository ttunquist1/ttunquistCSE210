class Event{
    private string _title {get; set;}
    private string _description {get; set;}
    private string _date {get; set;}
    private string _time {get; set;}
    private string _address {get; set;}
    private string _eventType {get; set;}

    public Event(string title, string description, string date, string time, string address, string eventType){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public void displayStandardDetails(){
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
    }

    public void displayFullDetails(){
        Console.WriteLine($"Type: {_eventType}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
    }

    public void displayShortDescription(){
        Console.WriteLine($"Event: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
    


}