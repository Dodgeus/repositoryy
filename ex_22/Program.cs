Console.WriteLine("выберите пространство: 1 - 2d; 2 - 3d");
int pr = int.Parse(Console.ReadLine());
if (pr == 1)
{
    Console.WriteLine("введите координату x 1 точки:");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("введтие координату y 1 точки:");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("введите координату x 2 точки:");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("введтие координату y 2 точки:");
    double y2 = double.Parse(Console.ReadLine());
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine(distance);
}
else if (pr == 2)
{
    Console.WriteLine("введите координату x 1 точки:");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("введтие координату y 1 точки:");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("введите координату z 1 точки:");
    double z1 = double.Parse(Console.ReadLine());
    Console.WriteLine("введтие координату x 2 точки:");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("введтие координату y 2 точки:");
    double y2 = double.Parse(Console.ReadLine());
    Console.WriteLine("введтие координату z 2 точки:");
    double z2 = double.Parse(Console.ReadLine());
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine(distance);
}
else
{
    Console.WriteLine("выпишите 1 или 2 ");
}