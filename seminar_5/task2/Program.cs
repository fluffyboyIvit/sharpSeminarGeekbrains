// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.



int[,] CreateMatrixRndInt(int rows, int column, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
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
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

int SumMainDiogonalMatrix(int[,] matrix)
{
    
    int sum = 0;
    int minSize= matrix.GetLength(0);
    if(matrix.GetLength(1)<minSize)
    {
        minSize= matrix.GetLength(1);
    }
    for (int i = 0; i < minSize; i++)
    {
        sum += matrix[i, i];

    }
    return sum;
}
int[,] array2d = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2d);
int result = SumMainDiogonalMatrix(array2d);
Console.WriteLine($" sum = {result}");