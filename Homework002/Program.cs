﻿Console.WriteLine("Введите первое число: ");
string a=Console.ReadLine();
double a1 = double.Parse(a);
Console.WriteLine("Введите второе число: ");
string b=Console.ReadLine();
double b1 = double.Parse(b);
Console.WriteLine("Введите третье число: ");
string с=Console.ReadLine();
double c1 = double.Parse(с);
double max=a1;
if(max<b1) max=b1;
if(max<c1) max=c1;
Console.Write("Максимальное число: ");
Console.WriteLine(max);