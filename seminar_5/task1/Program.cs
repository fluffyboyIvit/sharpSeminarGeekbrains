// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.



int[,] CreateMatrixRndInt(int rows,int column, int min, int max)
{
    int[,] matrix = new int[rows,column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    { for(int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i,j] = rnd.Next(min, max);
      } 
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {Console.Write("|");
     for (int j = 0; j < matrix.GetLength(1); j++)
    
        {
            Console.Write($"{matrix[i,j], 4} ");
        }
     Console.WriteLine("|");     
    }
}

void ElemEvenIndexsesToSquare(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i+=2)
  {
    for (int j = 0; j < matrix.GetLength(1); j+=2)
    {
        // if(i%2==0 && j%2==0)
        // {
            matrix[i,j] *= matrix[i,j];
        // }
    }
  }
}


Console.Write("Введите количество строк: ");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnMatrix= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxValue= Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMatrixRndInt(rowsMatrix,columnMatrix,  minValue,  maxValue);
PrintMatrix(array2d);
ElemEvenIndexsesToSquare(array2d);
Console.WriteLine();
PrintMatrix(array2d);


