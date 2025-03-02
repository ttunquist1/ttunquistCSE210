class Timer
{
    static DateTime _targetTime;

    public Timer(int seconds)
    {
        _targetTime = DateTime.Now.AddSeconds(seconds);
    }

    public static void SetTimer(int seconds)
    {
        _targetTime = DateTime.Now.AddSeconds(seconds);
    }

    public static bool IsTimeUp()
    {

        return DateTime.Now >= _targetTime;
    }

    public static void PauseWithAnimation(int seconds)
    {
        // simulate a pause with animation
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\r|");
            Thread.Sleep(250);
            Console.Write("\r/");
            Thread.Sleep(250);
            Console.Write("\r-");
            Thread.Sleep(250);
            Console.Write("\r\\");
            Thread.Sleep(250);
        }
    }
}