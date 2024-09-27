// Описание: Задайте массив из 10 элементов, заполненный числами от -10 до 10.
// Замените отрицательные числа на их абсолютные значения, а положительные числа
// на их отрицательные эквиваленты.
class Program
{
static void SwapSigns(int[] numbers)
{
// Введите свое решение ниже
int count = 0;
 while(count < numbers.Length)
 {  
    if(numbers[count] != 0)
    {
      numbers[count] *= -1;  
    }
    
    count++;
 }
}
static void Main(string[] args)
{
int[] numbers = { 1, -5, 6, -7, 3 }; // Пример массива
SwapSigns(numbers);
Console.WriteLine("[" + string.Join(", ", numbers) + "]");
}
}
