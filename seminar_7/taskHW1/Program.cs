// Описание: Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8


public class Answer
{
public static void PrintRange(int M, int N)
{
// Введите свое решение ниже
if(M == N)
{   Console.Write(M);
    return;
}
Console.Write($"{M}, ");
PrintRange(M+1,N);

}
static public void Main(string[] args)
{
int M = 4; // Можно поменять значение для проверки
int N = 8; // Можно поменять значение для проверки
Console.WriteLine("Числа в промежутке:");
PrintRange(M, N);
}
}
