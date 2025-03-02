class Breathing : Activity
{
    public Breathing(string title, string description, int duration) : base(title, description, duration)
    {
        
    }

    public void InteractBreathing()
    {
        Console.Clear();
        InteractPrologue();
        Timer.SetTimer(GetDuration());
        int breathIn = 3;
        int breathOut = 4;
        int totalBreaths = GetDuration() / (breathIn + breathOut);
        Console.Clear();
        for (int i = 0; i < totalBreaths; i++)
        {
            Console.WriteLine("Breathe in...");
            
            Timer.PauseWithAnimation(breathIn);
            Console.Clear();

            Console.WriteLine("Breathe out...");
            
            Timer.PauseWithAnimation(breathOut);
            Console.Clear();
        }
        InteractEpilogue();
        Thread.Sleep(10000);
    }
}