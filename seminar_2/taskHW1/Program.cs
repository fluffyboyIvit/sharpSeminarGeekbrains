// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>0)
{
    if(number%7==0 && number%23==0)
    {
        Console.WriteLine("число кратно");
    }
    else
    {
        Console.WriteLine("Число не кратно");
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}