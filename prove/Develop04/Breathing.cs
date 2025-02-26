class Breathing : Activity
{
    public Breathing(string title, string description, int duration) : base(title, description, duration)
    {
        
    }

    public void InteractBreathing()
    {
        InteractPrologue();
        Timer.SetTimer(GetDuration());
        int breathIn = 4;
        int breathOut = 6;
        int totalBreaths = GetDuration() / (breathIn + breathOut);
        for (int i = 0; i < totalBreaths; i++)
        {
            Console.WriteLine("Breathe in...");
            Timer.PauseWithAnimation(breathIn);
            Console.WriteLine("Breathe out...");
            Timer.PauseWithAnimation(breathOut);
        }
        InteractEpilogue();
    }
}