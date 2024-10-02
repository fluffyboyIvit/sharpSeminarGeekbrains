// // Задайте массив заполненный случайными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.




int[] CreateArrRndInt (int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min,max);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }

    }
    Console.Write("]");
}
int CountEvenNumInArr (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размер массива : ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;
int[] arr = CreateArrRndInt(sizeArr,min,max);
PrintArray(arr);
int result = CountEvenNumInArr(arr);
Console.Write($"=>{result}");

