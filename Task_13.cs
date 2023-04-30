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