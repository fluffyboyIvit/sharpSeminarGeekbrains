// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if(number>0)
{
    while(count<=number)
    {
        Console.Write(count);
        if(count<number)
        {
            Console.Write(",");
        }
        count++;
    }
}
else
{
    Console.WriteLine("Ошибка ввода");
}