void ArrayNew(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(1, 10);
    }
}
void ArrayPrint(int[] mas)
{
    for (int ind = 0; ind < mas.Length; ind++)
    {
        Console.Write(mas[ind] + " ");
    }
}
void ArraySumHonest(int[] arr)
{
    int pos = 0;
    int sum = 0;
    while (pos<arr.Length)
    {
        if (pos%2==0)
        {
            sum += arr[pos];
        }
        pos++;
    }   
    Console.WriteLine("сумма элементов массива по нечетному индексу: " + sum);
}
int[] array = new int[5];
ArrayNew(array);
ArrayPrint(array);
global::System.Console.WriteLine();
ArraySumHonest(array);
