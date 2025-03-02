class Reflection : Activity
{
    public Reflection(string title, string description, int duration) : base(title, description, duration) { }
    public void InteractReflection()
    {
        Console.Clear();
        InteractPrologue();
        Timer.SetTimer(GetDuration());
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        getPrompts();
        Console.WriteLine("When you have something in your mind, press any key to start reflecting.");
        Console.ReadLine();
        while (!Timer.IsTimeUp())
        {
            Console.WriteLine("Reflecting...");
            getFollowUps();
            Timer.PauseWithAnimation(10);
            Console.WriteLine();
        }
        InteractEpilogue();
    }

    private void getPrompts()
    {
        string[] prompts = new string[] 
        { 
            "Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult.", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless." 
        };
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
    }

    private void getFollowUps()
    {
        string[] followUps = new string[] 
        { 
            "Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did you get started?", 
            "How did you feel when it was complete?" ,
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "What did you learn about yourself through this experience?"
        };
        Random rand = new Random();
        int index = rand.Next(followUps.Length);    
        
        Console.WriteLine(followUps[index]);
    }
}