// Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: {1, 2, 3, 4, 5}
// ● Выход: 5, 4, 3, 2, 1
// ● Вход: {10, 20, 30, 40}
// ● Выход: 40, 30, 20, 10



public class Answer
{
public static void PrintArrayReverse(int[] array, int index)
{
// Введите свое решение ниже
if(index == 0)
{
    Console.Write(array[index]);
    return;
}
Console.Write($"{array[index]}, ");
PrintArrayReverse(array,index-1);
}
static public void Main(string[] args)
{
int[] array = { 10, 20, 30, 40, 50 }; // Можно поменять значениедля проверки
Console.WriteLine("Массив в обратном порядке:");
PrintArrayReverse(array, array.Length - 1);
}
}
