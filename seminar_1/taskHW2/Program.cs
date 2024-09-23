// Поиск среднего из трех чисел
// Описание: Напишите метод, который принимает на вход три числа и возвращает
// среднее из этих чисел (то есть не самое большое и не самое маленькое).



public class Answer {
static int FindMedian(int a, int b, int c)
{
// Введите свое решение ниже
if ((a<=b && b<=c) || (a>=b && b>=c))
{ 
    return b;
}
else if ((b<=a && a<=c) || (b>=a && a>=c))
{
    return a;
}
else
{
    return c;
}
}
static public void Main(string[] args) {
int a, b, c;
if (args.Length >= 3) {
a = int.Parse(args[0]);
b = int.Parse(args[1]);
c = int.Parse(args[2]);
} else {
a = 5;
b = 3;
c = 8;
}
int result = FindMedian(a, b, c);
System.Console.WriteLine($"{result}");
}
}