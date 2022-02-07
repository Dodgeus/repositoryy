Console.WriteLine("провеим ваше 5ти значное число на палиндромом: ");
int a = int.Parse(Console.ReadLine());
int a1 = a / 10000;
int a2 = (a / 1000) % 10;
int a3 = (a / 100) % 100;
int a4 = (a / 10) % 10;
int a5 = a % 10;
if(a1 == a5&& a2 == a4)
{
    Console.WriteLine("this is палиндромом");
}
else
{
    Console.WriteLine("no");
}