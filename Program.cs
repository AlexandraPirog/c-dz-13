Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99)
{
string chr = Convert.ToString(num);
System.Console.WriteLine ($"{chr[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/
