Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
for (int count = 0; count < b; count++)
{
    a = a + a;
}
Console.WriteLine(a);