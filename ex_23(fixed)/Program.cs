Console.WriteLine("введите число:");
double a = double.Parse(Console.ReadLine());
double count = 1;
double c = 1;
while (count <= a)
{
    c = Math.Pow(c, 2);
    Console.WriteLine(count + " " + c);
    count++;
    c = count;
}