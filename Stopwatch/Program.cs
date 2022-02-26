Menu();

void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Seconds => 10s = 10 seconds");
    Console.WriteLine("M = Minutes => 1m = 1 minute");
    Console.WriteLine("0 - Exit");
    Console.WriteLine("How long do you want to count?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    Console.WriteLine(type);
}

void Start(int time)
{
    int currentTime = 0;
    
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Stopwatch finished...");
    Thread.Sleep(2500);
}


