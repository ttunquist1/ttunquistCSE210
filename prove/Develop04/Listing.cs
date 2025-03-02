class Listing : Activity
{
    public Listing(string title, string description, int duration) : base(title, description, duration)
    {
    }

    public void InteractListing()
    {
        Console.Clear();
        InteractPrologue();
        Timer.SetTimer(GetDuration());
        Console.WriteLine();
        // display prompt
        getPrompts();
        // make a list of everthing that is written
        List<string> list = new List<string>();
        string input = Console.ReadLine();
        while (Timer.IsTimeUp() == false)
        {
            list.Add(input);
            input = Console.ReadLine();
        }
        //  display how many things you listed
        Console.WriteLine("You listed " + list.Count + " things.");
        InteractEpilogue();
    }

    private void getPrompts()
    {
        string[] prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        Random rand = new Random();
        int index = rand.Next(3);
        Console.WriteLine("Prompt: " + prompts[index]);
    }
}