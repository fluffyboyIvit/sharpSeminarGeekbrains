// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.




void PrintNaturalNum (int num)
{
    if(num != 1)
    {   
    PrintNaturalNum(num-1);
    }
    Console.WriteLine(num);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNaturalNum(number);