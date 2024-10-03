// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).
// Пример входных данных:
// 1 2
// 3 4
// 5 6
// Пример результата:
// 1 3 5
// 2 4 6



class Program
{
static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine(" |");
        }
    }
static void TransposeMatrix(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int[,] transposed = new int[cols, rows];
        // Введите свое решение ниже
        PrintMatrix(array);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] += array[i, j];
            }
        }
        PrintMatrix(transposed);
    }
    static void Main()
    {
        int[,] array =
        {
{ 1, 2 },
{ 3, 4 },
{ 5, 6 }
};
        TransposeMatrix(array);
    }
}
