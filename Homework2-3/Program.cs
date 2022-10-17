Console.WriteLine("Введите цифру дня недели: ");
int day = int.Parse(Console.ReadLine());
if (day==7 || day ==6) Console.WriteLine("Выходной");
else Console.WriteLine("Будний день");
