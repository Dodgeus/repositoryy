Console.WriteLine("введите номер дня недели:");
int a = int.Parse(Console.ReadLine());
if (a>0 && a<8)
{
    if (a > 5)
    {
        Console.WriteLine("ура сегодня выходной");
    }
    else
    {
        Console.WriteLine("сегодня будний, иди работай");
    }
}
else
{
    Console.WriteLine("такого дня недели не существует");
}