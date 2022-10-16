Console.WriteLine("Введите число: ");
string N1=Console.ReadLine();
int N = int.Parse(N1);
for (int i=2; i<=N; i+=2)
{
    Console.WriteLine(i);
}