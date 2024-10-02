// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

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
int[] InvertArray(int[]array)
{
    int right = array.Length - 1;
    int num = 0;
    for (int left = 0; left < array.Length/2; left++)
    {
        num = array[left];
        array[left] = array[right];
        array[right] = num;
        right--;
        
    }
    return array;
}

Console.Write("Введите размер массива : ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 100;
int[] arr = CreateArrRndInt(sizeArr,min,max);
PrintArray(arr);

int[] arrInvert = InvertArray(arr);
PrintArray(arrInvert);