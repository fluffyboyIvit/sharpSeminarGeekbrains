// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.


Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber && firstNumber > 0 && secondNumber > 0)
{
    int remainder = firstNumber % secondNumber;
    if (remainder == 0)
    {
        Console.WriteLine("Число кратно второму.");
    }
    else
    {
       
        Console.WriteLine($"Число не кратно! остаток: {remainder}");
    }
}
else
{
    Console.WriteLine("Ошибка ввода");
}