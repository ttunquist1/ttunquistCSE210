using System.Dynamic;

class Activity
{
    private string _title;
    private string _description;
    private int _duration;
    
    public Activity(string title, string description, int duration){
        _title = title;
        _description = description;
        _duration = duration;
    }

    public int GetDuration(){
        return _duration;
    }
    
    public void InteractPrologue(){
        Console.WriteLine("You are about to start the activity: " + _title);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("The activity will take " + _duration + " seconds.");
        Console.WriteLine("Press any key to start the activity.");
        Console.ReadKey();
    }

    public void InteractEpilogue(){
        Console.WriteLine("The activity is done.");

    }
}