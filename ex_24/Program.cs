global::System.Console.WriteLine("введтие число:");
double a = double.Parse(Console.ReadLine());
int count = 1;
double c = 1;
while (count<=a)
{
    c = Math.Pow(c, 3);
    global::System.Console.WriteLine(count + " " + c);
    count++;
    c = count;
}