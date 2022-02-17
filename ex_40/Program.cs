void ArrayNew(double[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(1, 10);
    }
}
void ArrayPrint(double[] mas)
{
    for (int ind = 0; ind < mas.Length; ind++)
    {
        Console.Write(mas[ind] + " ");
    }
}
void ArrayMaxMin(double[] arr)
    {
        int pos = 0;
        double max = arr[pos];
        double min = arr[pos];
           while(pos < arr.Length)
           {
               if (arr[pos] > max) max = arr[pos];
               if (arr[pos] < min) min = arr[pos];
               pos++;
           }
        Console.WriteLine("максимальное значение: " + max);
        Console.WriteLine("минимальное значение: "+ min);
        double raz = max - min;
        Console.WriteLine("разность: " + raz);
     }
double[] array = new double[6];
ArrayNew(array);
ArrayPrint(array);
Console.WriteLine();
ArrayMaxMin(array);