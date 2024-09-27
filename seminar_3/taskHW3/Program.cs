// Описание: Задайте массив целых чисел. Напишите программу, которая проверяет,
// присутствует ли заданное число в массиве. Программа должна вывести:
// Присутствует/Не присутствует.

class Program
{
static bool IsNumberPresent(int[] numbers, int numberToFind)
{
// Введите свое решение ниже
bool isExistNum = false;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == numberToFind)
    {
        isExistNum = true;
        break;
    }
}
return isExistNum;
 
}
static void Main(string[] args)
{
int[] numbers = { 1, 3, 4, 19, 3 }; // Пример массива
int numberToFind = 8; // Пример числа для поиска
if (IsNumberPresent(numbers, numberToFind))
{
Console.WriteLine("Присутствует");
}
else
{
Console.WriteLine("Не присутствует");
}
}
}