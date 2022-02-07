global::System.Console.Write("задайте номер четверти: ");
int a = int.Parse(Console.ReadLine());
if (a>0 && a < 5)
{
    if (a == 1)
    {
        Console.WriteLine("x (0;+inf) y (0;+inf)");
    }
    else if (a == 2)
    {
        gConsole.WriteLine("x (-inf;0) y (0;+inf)");
    }
    else if (a == 3)
    {
        Console.WriteLine("x (-inf;0) y (-inf;0)");
    }
    else if(a == 4)
    {
        Console.WriteLine("x (0;+inf) y (-inf;0)");
    }
}
else
{
    Console.WriteLine("такой четверти не существует)");
}