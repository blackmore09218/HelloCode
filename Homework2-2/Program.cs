Console.WriteLine("Ввведите число: ");
string numberStr = Console.ReadLine();
int len = numberStr.Length;
if (len>2)
{
    int number = int.Parse(numberStr);
    Console.Write("Третья цифра введенного числа - ");
    Console.WriteLine((number/Convert.ToInt32(Math.Pow(10,len-3)))%10);
}
else Console.WriteLine("Третьей цифры нет");
