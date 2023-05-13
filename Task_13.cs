//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");

string str = Console.ReadLine();

if (str.Length < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(str[2]);
}
