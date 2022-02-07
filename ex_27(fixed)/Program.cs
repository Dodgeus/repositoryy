//Определить количество цифр в числе
Console.Write("введите число:");
int a = int.Parse(Console.ReadLine());
int c = 0;
for (int count = 1; a > 0; count++)
{
    a = a / 10;
    c = count;
}
global::System.Console.WriteLine("это "+ c+ " значное число");