Console.WriteLine("Введите имя пользователя:  ");
string name = Console.ReadLine();
if(name.ToLower() == "маша")
{
    Console.Write("Ура!!! Это же " );
    Console.WriteLine(name);
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(name);
}
