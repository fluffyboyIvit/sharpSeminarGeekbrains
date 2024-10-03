// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример

// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4


int[,] CreateMatrixRndInt(int rows, int column, int min , int max)
{
    Random rnd = new Random();
    int[,] matrix = new int [rows,column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine(" |");
    }
}

double [] AvrRowsMatrix(int[,] matrix)
{
    double[] array= new double [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] += matrix[i,j];
        }
        array[i] /= matrix.GetLength(1);
    }
    return array;
}

void PrintArray(double[] array)
{   Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:F2} ");
    }
    Console.Write("]");
}

int[,] array2d = CreateMatrixRndInt(3,4,1,10);
PrintMatrix(array2d);
double[] arr = AvrRowsMatrix(array2d);
Console.WriteLine();
PrintArray(arr);