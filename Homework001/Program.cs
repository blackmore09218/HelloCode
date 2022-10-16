/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.WriteLine("Введите первое число: ");
string a=Console.ReadLine();
double a1 = double.Parse(a);
Console.WriteLine("Введите второе число: ");
string b=Console.ReadLine();
double b1 = double.Parse(b);
if(a1>b1)
{
    Console.Write("max = ");
    Console.WriteLine(a1);
}
else 
{
    if(a1<b1)
    {
        Console.Write("max = ");
        Console.WriteLine(b1);
    }
    else
    {
        Console.WriteLine("Оба числа равны");
    }
}