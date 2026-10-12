var n = 0;
while (true)
{
    n++;
    Console.WriteLine($"hello from csharp, tick {n}");
    Thread.Sleep(TimeSpan.FromSeconds(60));
}
