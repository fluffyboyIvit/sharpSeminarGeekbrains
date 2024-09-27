// Описание: Задайте массив из 10 целых чисел. Найдите среднее значение элементов
// массива.

class Program
{
static double CalculateAverage(int[] numbers)
{
// Введите свое решение ниже
 double sum = 0;
 int count = 0;
 while(count<numbers.Length)
 {
    sum += numbers[count];
    count++;
 }
 return sum / numbers.Length;

}
static void Main(string[] args)
{
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Пример массива
double average = CalculateAverage(numbers);
Console.WriteLine(average);
}
}