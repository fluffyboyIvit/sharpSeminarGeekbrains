// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

int number = 10;
int[] array = new int [number];

for(int i=0 ; i <array.Length;i++)
{   
    Console.WriteLine($"Введите {i+1}число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i=0 ; i <array.Length;i++)
{  
    array[i] *= -1;
    Console.Write($"{array[i]} ");
}
