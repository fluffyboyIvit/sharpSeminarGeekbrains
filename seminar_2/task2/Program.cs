// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре



int number;

Console.Write("Введите трёзначное число: ");
number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int secondDigit = number / 10 % 10;
    int lastDigit = number % 10;
    int Count = 0;
    int result = 1;
    while (Count < lastDigit)
    {
        result = result * secondDigit;
        Count++;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка ввода!");
}