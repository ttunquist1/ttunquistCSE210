using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Activity sample = new Activity("Sample Activity", "This is a sample activity.", 20);
        sample.InteractPrologue();
        Timer.SetTimer(sample.GetDuration());
        Timer.PauseWithAnimation(sample.GetDuration());
        Console.WriteLine();
        sample.InteractEpilogue();
    }
}