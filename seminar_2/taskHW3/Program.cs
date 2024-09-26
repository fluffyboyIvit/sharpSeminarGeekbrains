// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(10<=number&&number<=99)
{
    int firstDigit = number/ 10;
    int secondDigit = number % 10;
    if(firstDigit>secondDigit)
    {
        Console.WriteLine($"Большая цифра {firstDigit}");
    }
    else
    {
        Console.WriteLine($"Большая цифра {secondDigit}");
    }
}
else
{
    Console.WriteLine("Ошибка ввода");
}