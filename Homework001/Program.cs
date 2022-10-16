Console.WriteLine("Введите первое число: ");
string a=Console.ReadLine();
double a1 = double.Parse(a);
Console.WriteLine("Введите второе число: ");
string b=Console.ReadLine();
double b1 = double.Parse(b);
if(a1>b1)
{
    Console.Write("max = "); Console.WriteLine(a1);
}
else 
{
    if(a1<b1)
    {
        Console.Write("max = "); Console.WriteLine(b1);
    }
    else
    {
        Console.WriteLine("Оба числа равны");
    }
}