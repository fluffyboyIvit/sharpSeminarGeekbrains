// Вывести нечетные числа
// Описание: Напишите метод, который на вход принимает число (number), а на выходе
// выводит все нечетные числа от 1 до number (включительно), после каждого числа
// должен быть знак пробела.


public class Answer {
static void PrintOddNumbers(int number)
{
// Введите свое решение ниже
int count = 0;
while(count< number)
{
    count++;
    if (count % 2 == 1)
    {
        Console.Write($" {count}");
    }
}
}
static public void Main(string[] args) {
int number;
if (args.Length >= 1) {
number = int.Parse(args[0]);
} else {
number = 5;
}
PrintOddNumbers(number);
}
}
