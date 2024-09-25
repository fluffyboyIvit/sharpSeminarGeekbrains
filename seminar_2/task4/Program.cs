// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.

// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100)
{
    int lastdigit;
    int thirddigit;
    if (number <= 999)
    {
        lastdigit = number % 10;
        Console.WriteLine(lastdigit);
    }
    else
    {
        thirddigit = number / 100 % 10;
        Console.WriteLine(thirddigit);
    }
}
else
{
    Console.WriteLine("Третьей цифры нет");
}