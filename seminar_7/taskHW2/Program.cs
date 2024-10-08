// Описание: Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// Пример:
// ● Вход: m = 2, n = 3
// ● Выход: A(m, n) = 29 <= !!!!тут ошибка выводит 9!при m = 3 ,n = 2 выводит 29!!!!
// ● Вход: m = 1, n = 4
// ● Выход: A(m, n) = 7 <= !!!!тут тоже ошибка, будет 6! а если наоборот переполнение стека!!!!
public class Answer
{
public static int Ackermann(int m, int n)
{
// Введите свое решение ниже
if (m == 0)
{
    return n + 1;
}
     
else if (n == 0)
{
    return Ackermann (m - 1, 1);
}
     
else if(m>0 && n>0)
{
    return Ackermann(m - 1, Ackermann (m, n - 1));
}
return 0;

}
static public void Main(string[] args)
{
int m = 1; // Можно поменять значение для проверки
int n = 4; // Можно поменять значение для проверки
int result = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
}
}