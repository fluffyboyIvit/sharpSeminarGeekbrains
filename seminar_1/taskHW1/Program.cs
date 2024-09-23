// Описание: Напишите метод, который на вход принимает два целых числа и проверяет,
// делится ли первое число на второе. Если делится, выводите "делится", иначе
// выводите "не делится".


public class Answer {
static void CheckDivisibility(int firstNumber, int secondNumber)
{
// Введите свое решение ниже
if(secondNumber != 0)
{
    if (firstNumber % secondNumber == 0)
    {
        Console.WriteLine("делится");
    }
    else
    {
        Console.WriteLine("не делится");
    }
}
else
{
    Console.WriteLine("Ошибка ввода");
}
}
static public void Main(string[] args) {
int firstNumber, secondNumber;
if (args.Length >= 2) {
firstNumber = int.Parse(args[0]);
secondNumber = int.Parse(args[1]);
} else {
firstNumber = 10;
secondNumber = 2;
}
CheckDivisibility(firstNumber, secondNumber);
}
}