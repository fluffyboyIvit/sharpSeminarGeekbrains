//  Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.



string CharArrayToString(char[,] array)
{   string res = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res += array[i,j];
        }
    }
    return res;
}

void PrintCharMatrix(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {  Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j], 3}");
        }
        Console.WriteLine(" |");
    }
}

char[,] charArr =
  {
  { 'a', 'b', 'c' },
  { 'd', 'e', 'f' }
  };
PrintCharMatrix(charArr);
string str = CharArrayToString(charArr);
Console.WriteLine(str);