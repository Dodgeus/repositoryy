int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
if (x==0 | y == 0)
{
    global::System.Console.WriteLine("X OR Y = 0");
}
else if (y > 0)
{
    if (x > 0)
    {
        global::System.Console.WriteLine("1 четверть");
    }
    else
    {
        global::System.Console.WriteLine("2 четверть");
    }
}
else
{
    if (x > 0)
    {
        global::System.Console.WriteLine("4 четверть");
    }
    else
    {
        global::System.Console.WriteLine("3 четверть");
    }
}