// Описание: Задайте двумерный массив. Замените все отрицательные числа на их
// абсолютные значения.
// Пример входных данных:
// 1 -2 3
// -4 5 -6
// 7 -8 9
// Пример результата:
// 1 2 3
// 4 5 6
// 7 8 9


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
static void ReplaceNegativeNumbers(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        // Введите свое решение ниже
        PrintMatrix(array);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] < 0)
                {
                    array[i,j] = array[i, j] * -1;
                }
            }
        }
        Console.WriteLine();
        PrintMatrix(array);
    }
static void Main()
{
int[,] array =
{
{ 1, -2, 3 },
{ -4, 5, -6 },
{ 7, -8, 9 }
};
ReplaceNegativeNumbers(array);
}
}