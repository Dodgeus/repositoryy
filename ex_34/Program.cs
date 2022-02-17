void ArrayNew(int[] massive)
{
    for (int i = 0;i<massive.Length; i++)
    {
        massive[i] = new Random().Next(-9,10);
    }
}
void ArrayRevers(int[] col)
{
    for (int index = 0; index<col.Length; index++)
    {
        col[index] = -col[index];
    }
}
void ArrayPrint(int[] mas)
{
    for (int ind = 0; ind<mas.Length; ind++)
    {
        Console.Write(mas[ind] + " ");
    }
}
int[] array = new int[8];
ArrayNew(array);
ArrayPrint(array);
Console.WriteLine();
ArrayRevers(array);
ArrayPrint(array);
Console.WriteLine();