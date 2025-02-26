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
        for (int i = 0; i < seconds / 2; i++)
        {
            Console.Write("\rLoading");
            Thread.Sleep(500);
            Console.Write("\rLoading.");
            Thread.Sleep(500);
            Console.Write("\rLoading. .");
            Thread.Sleep(500);
            Console.Write("\rLoading. . .");
            Thread.Sleep(500);
            Console.Write("\r\b            \b");
        }
    }
}