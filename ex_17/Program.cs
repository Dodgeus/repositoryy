global::System.Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine());
global::System.Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine());
if (a*a==b | b*b==a)
{
    global::System.Console.WriteLine("одно является квадратом другого");
}
else
{
    global::System.Console.WriteLine("не является");
}