// Описание: Задайте массив целых чисел. Напишите программу, которая удаляет все
// отрицательные числа из массива и возвращает новый массив, содержащий только
// неотрицательные числа.

class Program
{
static int[] RemoveNegatives(int[] numbers)
{
// Введите свое решение ниже
 int count = 0;
 for(int i = 0; i < numbers.Length;i++)
 {
    if(numbers[i]>0)
    {
        count++;
    }
    i++;
 }
  int[] array = new int [count];
  int index = 0;
  for(int i = 0; i < numbers.Length;i++)
 {
    if(numbers[i]>0)
    {
        array[index] = numbers[i];
        index++;
    }
    i++;
 }
 return array;
}
static void Main(string[] args)
{
int[] numbers = { 5, -3, 9, -1, 2, -7, 0 }; // Пример массива
int[] result = RemoveNegatives(numbers);
Console.WriteLine("[" + string.Join(", ", result) + "]");
}
}
