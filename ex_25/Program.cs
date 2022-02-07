global::System.Console.Write("введите число:");
int a = int.Parse(Console.ReadLine());
int c = 1;
int summ = 1;
for (int count = 1; count<a; c = count)
{
    c = c + 1;
    summ = summ + c;
    count++;
}
Console.WriteLine("сумма от 1 до " + a + " = " + summ);