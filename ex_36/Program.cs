void ArrayNew(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(100, 1000);
    }
}
void ArrayHonest(int[] arr)
{
    int pos = 0;
    int hon = 0;
    int hon2 = 0;
    while (pos < arr.Length) 
    {
        if (arr[pos] % 2 == 0)
        {
            hon = hon + 1;
        }
        else
        {
            hon2 =  hon2 + 1;
        }
        pos++;
    }
    Console.WriteLine("четных: " + hon);
    Console.WriteLine("нечетных: " + hon2);
}
void ArrayPrint(int[] mas)
{
    for (int ind = 0; ind < mas.Length; ind++)
    {
        Console.Write(mas[ind] + " ");
    }
}
int[] array = new int[5];
ArrayNew(array);
ArrayPrint(array);
Console.WriteLine();
ArrayHonest(array);