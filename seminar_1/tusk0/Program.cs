﻿// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

int num1;
int num2;

Console.Write("Введите первое число:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число:");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2*num2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else{
    Console.WriteLine("Первое число не является квадратом второго");
}